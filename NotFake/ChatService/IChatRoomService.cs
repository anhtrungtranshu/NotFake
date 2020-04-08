﻿using NotFake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.ChatService
{
    public interface IChatRoomService
    {
        Task<Guid> CreateRoom(string filmId);
        Task<Guid> GetRoomForFilmId(string filmId);
        Task<IReadOnlyDictionary<Guid, ChatRoom>> GetAllRooms();
    }
}
