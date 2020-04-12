using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using DAO.Models;
using NotFake.ChatService;
using Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NotFake.Models;

namespace NotFake.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRoomService _chatRoomService;
        private INotFakeService _notFakeService;

        public ChatHub(IChatRoomService chatRoomService, INotFakeService notFakeService)
        {
            _chatRoomService = chatRoomService;
            _notFakeService = notFakeService;
        }
        public override async Task OnConnectedAsync()
        {
            //provide a list of active connections
            // await Clients.Caller.SendAsync(
            //     "ActiveConnections",
            //     await _chatRoomService.GetAllRooms());

            await Clients.Caller.SendAsync("Connected");
            //connect user to own room
            //var roomId = await _chatRoomService.CreateRoom(Context.ConnectionId);
            //await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _chatRoomService.RemoveDisconnectedUser(Context.ConnectionId);
            await base.OnDisconnectedAsync(exception);
        }

        public async Task Authorize(string userEmail, string formValue, bool requestCreateGroup)
        {
            if (!String.IsNullOrEmpty(userEmail))
            {
                await _chatRoomService.AddConnectedUser(Context.ConnectionId, userEmail);

                if (!String.IsNullOrEmpty(formValue))
                {
                    JObject form = JObject.Parse(formValue);
                    if (!requestCreateGroup)
                    {
                        bool hasGroupName = !String.IsNullOrEmpty((string)form["GroupName"]);

                        Guid roomName = hasGroupName ? _chatRoomService.CheckRoomExist((string)form["GroupName"])
                                            : _chatRoomService.CheckRoomExist((string)form["FilmId"], userEmail);

                        if (roomName != Guid.Empty)
                        {
                            await Groups.AddToGroupAsync(Context.ConnectionId, roomName.ToString());
                            await Clients.Caller.SendAsync("Authorized", new
                            {
                                GroupName = roomName.ToString()
                            });
                            return;
                        }
                    }
                    else
                    {
                        Group previousGroup = _chatRoomService.CheckRoomExistInDB((string)form["FilmId"], userEmail);
                        if (previousGroup != null)
                        {
                            await Clients.Caller.SendAsync("ChatRequireAction", new
                            {
                                message = "Do you want to load previous  group chat for this film?"
                            });
                        }
                        else
                        {
                            try
                            {
                                Guid guid = _chatRoomService.CreateRoom((string)form["FilmId"], userEmail);
                                await Groups.AddToGroupAsync(Context.ConnectionId, guid.ToString());
                                await Clients.Caller.SendAsync("Authorized", new
                                {
                                    GroupName = guid.ToString()
                                });
                            }
                            catch
                            {
                                await Clients.Caller.SendAsync("Error", new
                                {
                                    success = false,
                                    message = "There is an internal error, please try again later"
                                });
                            }
                        }
                    }
                }
                // user only authorize with email
                await Clients.Caller.SendAsync("Authorized");
            }
            else
            {
                // user send wrong info
                await Clients.Caller.SendAsync("Error", new
                {
                    message = "Information is not correct"
                });
            }
        }

        public async Task CreateGroup(string userEmail, string formValue, bool usePreviousGroup)
        {
            try
            {
                JObject form = JObject.Parse(formValue);
                Guid guid;
                List<HubPost> posts = new List<HubPost>();
                if (usePreviousGroup)
                {
                    Group previousGroup = _chatRoomService.CheckRoomExistInDB((string)form["FilmId"], userEmail);
                    posts = _chatRoomService.GetPostsOfGroup(previousGroup);
                    guid = _chatRoomService.CreateRoom(previousGroup);
                }
                else
                {
                    guid = _chatRoomService.CreateRoom((string)form["FilmId"], userEmail);
                }

                await Groups.AddToGroupAsync(Context.ConnectionId, guid.ToString());

                await Clients.Caller.SendAsync("Authorized", new HubGroup
                {
                    GroupName = guid.ToString(),
                    Posts = posts
                });
            }
            catch
            {
                await Clients.Caller.SendAsync("Error", new
                {
                    success = false,
                    message = "There is an internal error, please try later"
                });
            }
        }

        public async Task SendMessage(string message)
        {
            HubMessage msg = JsonConvert.DeserializeObject<HubMessage>(message);
            HubPost newPost = _chatRoomService.AddPostToGroup(msg);
            await Clients.Group(msg.GroupName).SendAsync("ReceiveMessage", newPost);
        }

        public async Task LeaveRoom(Guid roomId)
        {
            await Groups.RemoveFromGroupAsync(
                Context.ConnectionId, roomId.ToString());
        }



    }
}
