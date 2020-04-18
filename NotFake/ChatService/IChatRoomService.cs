using DAO.Models;
using NotFake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.ChatService
{
    public interface IChatRoomService
    {
        Task<User> AddConnectedUser(string ConnectionId, string userEmail);
        KeyValuePair<string, User> GetConnectedUser(string userEmail);
        KeyValuePair<string, User> GetConnectedUser(User user);
        void RemoveDisconnectedUser(string ConnectionId);
        Guid CreateRoom(string filmId, string userEmail);
        Guid CreateRoom(Group group);
        Task<IReadOnlyDictionary<Guid, ChatRoom>> GetAllRooms();
        Guid CheckRoomExist(string groupName);
        Guid CheckRoomExist(string FilmId, string userEmail);
        Group CheckRoomExistInDB(string FilmId, string userEmail);
        HubPost AddPostToGroup(HubMessage message);
        List<HubPost> GetPostsOfGroup(Group group);
        List<HubPost> GetPostsOfGroup(Guid guid);
        List<HubUser> GetMemberOfGroup(Guid guid);
        List<HubUser> GetUserFriendList(string email, string keyword);
        List<HubUser> GetFriendSuggestions(string email, string keyword);
        KeyValuePair<string, User> AddFriendRequest(string email, string requestToEmail);
    }
}
