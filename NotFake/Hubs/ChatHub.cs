using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using DAO.Models;
using NotFake.ChatService;

namespace NotFake.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IChatRoomService _chatRoomService;

        public ChatHub(IChatRoomService chatRoomService)
        {
            _chatRoomService = chatRoomService;
        }
        public override async Task OnConnectedAsync()
        {
            var roomId = await _chatRoomService.CreateRoom(
                Context.ConnectionId);
            await Groups.AddToGroupAsync(Context.ConnectionId, roomId.ToString());
        }
        public async Task SendMessage(string user, string message)
        {
            var roomID = await _chatRoomService.GetRoomForConnectionId(
                Context.ConnectionId);

            await Clients.Group(roomID.ToString()).SendAsync("ReceiveMessage", user, message);
        }
    }
}
