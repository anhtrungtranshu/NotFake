using NotFake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.ChatService
{
    public class InMemoryChatRoomService : IChatRoomService
    {
        private readonly Dictionary<Guid, ChatRoom> _roomInfo
            = new Dictionary<Guid, ChatRoom>();
        public Task<Guid> CreateRoom(string filmId)
        {
            var id = Guid.NewGuid();
            _roomInfo[id] = new ChatRoom
            {
                RoomFilmID = filmId
            };
            return Task.FromResult(id);
        }

        public Task<IReadOnlyDictionary<Guid, ChatRoom>> GetAllRooms()
        {
            return Task.FromResult(
                _roomInfo as IReadOnlyDictionary<Guid, ChatRoom>);
        }

        public Task<Guid> GetRoomForFilmId(string filmId)
        {
            var foundRoom = _roomInfo.FirstOrDefault(
                x => x.Value.RoomFilmID == filmId);

            if (foundRoom.Key == Guid.Empty)
            {
                return null;
            }
            else 
            { 
                return Task.FromResult(foundRoom.Key);
            }
        }
    }
}
