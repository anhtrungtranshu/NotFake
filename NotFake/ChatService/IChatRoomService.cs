using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.ChatService
{
    public interface IChatRoomService
    {
        Task<Guid> CreateRoom(string connectionId);
        Task<Guid> GetRoomForConnectionId(string connectionId);
    }
}
