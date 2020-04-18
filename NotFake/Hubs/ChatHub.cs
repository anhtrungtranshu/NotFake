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
using Microsoft.AspNetCore.Authorization;

namespace NotFake.Hubs
{
    // [Authorize] 
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
                            List<HubPost> postOfGroup = _chatRoomService.GetPostsOfGroup(roomName);
                            List<HubUser> memberOfGroup = _chatRoomService.GetMemberOfGroup(roomName);
                            await Groups.AddToGroupAsync(Context.ConnectionId, roomName.ToString());
                            await Clients.Caller.SendAsync("Authorized", new HubGroup()
                            {
                                GroupName = roomName.ToString(),
                                Posts = postOfGroup,
                                Members = memberOfGroup
                            });
                            return;
                        }
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

        public async Task GroupFriendSuggestions(string keyword)
        {

            await Clients.Caller.SendAsync("GroupFriendSuggestions", new List<HubUser>()
            {
                new HubUser(){
                    UserEmail = "a@demo.com",
                    UserName = "a"
                },
                new HubUser(){
                    UserEmail = "b@demo.com",
                    UserName = "b"
                },
                new HubUser(){
                    UserEmail = "c@demo.com",
                    UserName = "c"
                },
                new HubUser(){
                    UserEmail = "d@demo.com",
                    UserName = "d"
                },
                new HubUser(){
                    UserEmail = "e@demo.com",
                    UserName = "e"
                }
            });
        }

        public async Task GetUserFriendList(string data)
        {
            JObject obj = JObject.Parse(data);
            List<HubUser> _friendList = _chatRoomService.GetUserFriendList((string)obj["email"], (string)obj["keyword"]);
            await Clients.Caller.SendAsync("GetUserFriendList", _friendList);
        }

        public async Task GetFriendSuggestions(string data)
        {
            JObject obj = JObject.Parse(data);
            if ((string)obj["keyword"] == "")
            {
                await Clients.Caller.SendAsync("GetFriendSuggestions", new List<HubUser>());
                return;
            }
            List<HubUser> _friendSuggestionList = _chatRoomService.GetFriendSuggestions((string)obj["email"], (string)obj["keyword"]);
            await Clients.Caller.SendAsync("GetFriendSuggestions", _friendSuggestionList);
        }

        public async Task RequestFriend(string data)
        {
            try
            {
                JObject obj = JObject.Parse(data);
                User invitingUser = _notFakeService.User.GetByEmail((string)obj["email"]);
                KeyValuePair<string, User> invitedUser = _chatRoomService.AddFriendRequest((string)obj["email"], (string)obj["requestTo"]);
                if (!object.Equals(invitedUser, default(KeyValuePair<string, User>)))
                {
                    await Clients.Client(invitedUser.Key).SendAsync("IncommingFriendRequest", new
                    {
                        // message = String.Format("You have a friend request from {0}", invitingUser.Fullname),
                        invitingUserEmail = invitingUser.Email,
                        invitingUserName = invitingUser.Fullname
                    });
                }
                await Clients.Caller.SendAsync("RequestFriend", new
                {
                    message = "Friend request sent"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task LeaveRoom(Guid roomId)
        {
            await Groups.RemoveFromGroupAsync(
                Context.ConnectionId, roomId.ToString());
        }



    }
}
