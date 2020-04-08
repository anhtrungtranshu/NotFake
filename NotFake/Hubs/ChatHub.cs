using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using DAO.Models;
using NotFake.ChatService;
using Service;

namespace NotFake.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRoomService _chatRoomService;
        //private INotFakeService _notFakeService;

        public ChatHub(IChatRoomService chatRoomService )//,INotFakeService notFakeService)
        {
            _chatRoomService = chatRoomService;
           // _notFakeService = notFakeService;
        }
        public override async Task OnConnectedAsync()
        {
            //provide a list of active connections
            await Clients.Caller.SendAsync(
                "ActiveConnections",
                await _chatRoomService.GetAllRooms());

            //connect user to own room
            //var roomId = await _chatRoomService.CreateRoom(Context.ConnectionId);
            //await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
        }
        public async Task SendMessage(string user, string message, string filmId)
        {
            var roomID = await _chatRoomService.GetRoomForFilmId(filmId);

            await Clients.Group(roomID.ToString()).SendAsync("ReceiveMessage", user, message);
        }

        public async Task Chat(string filmId)
        {
            if (_chatRoomService.GetRoomForFilmId(filmId) == null)
            {
                var roomId = await _chatRoomService.CreateRoom(filmId);
                await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
            }
            else
            {
                var roomId = await _chatRoomService.GetRoomForFilmId(filmId);
                await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
            }   
          
        }
        //public async Task JoinRoom(Guid roomId)
        //{
        //    await Groups.AddToGroupAsync(
        //        Context.ConnectionId, roomId.ToString());
        //}

        public async Task LeaveRoom(Guid roomId)
        {
            await Groups.RemoveFromGroupAsync(
                Context.ConnectionId, roomId.ToString());
        }

    }
}
