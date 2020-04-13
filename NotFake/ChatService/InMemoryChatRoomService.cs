using NotFake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using Service;
using Microsoft.Extensions.DependencyInjection;

namespace NotFake.ChatService
{
    public class InMemoryChatRoomService : IChatRoomService, IDisposable
    {
        private readonly IServiceScope _scope;
        private INotFakeService _notFakeService;
        // list of lasting Groups
        private static readonly Dictionary<Guid, Group> _roomInfo = new Dictionary<Guid, Group>();
        // list of online users;
        private static readonly Dictionary<string, User> _listConnectedUsers = new Dictionary<string, User>();
        public InMemoryChatRoomService(IServiceProvider services)
        {
            _scope = services.CreateScope();
            _notFakeService = _scope.ServiceProvider.GetService<INotFakeService>();
        }

        public Task<User> AddConnectedUser(string ConnectionId, string userEmail)
        {
            if (_listConnectedUsers.ContainsKey(ConnectionId))
            {
                return Task.FromResult(_listConnectedUsers[ConnectionId]);
            }
            else
            {
                User _user = _notFakeService.User.GetByEmail(userEmail);
                if (_user != null)
                {
                    _listConnectedUsers.Add(ConnectionId, _user);
                }
                return Task.FromResult(_user);
            }
        }

        public void RemoveDisconnectedUser(string ConnectionId)
        {
            _listConnectedUsers.Remove(ConnectionId);
        }

        public Guid CheckRoomExist(string groupName)
        {
            Guid gName = Guid.Parse(groupName);
            return _roomInfo.ContainsKey(gName) ? gName : Guid.Empty;
        }

        public Guid CheckRoomExist(string FilmId, string userEmail)
        {
            int _filmId;
            Int32.TryParse(FilmId, out _filmId);
            User _user = _notFakeService.User.GetByEmail(userEmail);
            KeyValuePair<Guid, Group> gPair = _roomInfo.Where(r => r.Value.CreatorId == _user.UserId && r.Value.FilmId == _filmId).FirstOrDefault();
            return gPair.Key;
        }

        public Group CheckRoomExistInDB(string FilmId, string userEmail)
        {
            int _filmId;
            bool filmIdParsed = Int32.TryParse(FilmId, out _filmId);

            User _user = _notFakeService.User.GetByEmail(userEmail);
            if (_user != null)
            {
                Group previousGroup = _notFakeService.Group.Get(_filmId, _user.UserId);
                return previousGroup;
            }
            return null;
        }
        public Guid CreateRoom(string filmId, string userEmail)
        {
            User _user = _notFakeService.User.GetByEmail(userEmail);
            int _filmId;
            bool isParsed = Int32.TryParse(filmId, out _filmId);
            Film _film = _notFakeService.Film.Get(_filmId);

            // create new group in database
            Group _createdGroup = _notFakeService.Group.Add(new Group()
            {
                Film = _film,
                Creator = _user,
                Created = DateTime.Now,
            });

            // add admin to group as member
            _notFakeService.GroupMembers.Add(new GroupMembers()
            {
                Group = _createdGroup,
                Member = _user
            });

            var id = Guid.NewGuid();
            _roomInfo[id] = _createdGroup;
            return id;
        }

        public Guid CreateRoom(Group group)
        {
            var guid = Guid.NewGuid();
            _roomInfo[guid] = group;
            return guid;
        }
        public Task<IReadOnlyDictionary<Guid, ChatRoom>> GetAllRooms()
        {
            return Task.FromResult(
                _roomInfo as IReadOnlyDictionary<Guid, ChatRoom>);
        }

        public HubPost AddPostToGroup(HubMessage message)
        {
            Group _group = _roomInfo[Guid.Parse(message.GroupName)];
            User _creator = _notFakeService.User.GetByEmail(message.UserEmail);
            Post newPost = _notFakeService.Post.Add(new Post()
            {
                Content = message.Message,
                Created = DateTime.Now,
                Group = _group,
                Creator = _creator
            });

            return new HubPost()
            {
                Message = newPost.Content,
                UserName = newPost.Creator.Fullname,
                UserEmail = newPost.Creator.Email,
                Created = newPost.Created
            };
        }

        public List<HubPost> GetPostsOfGroup(Group group)
        {
            return _notFakeService.Post.GetPosts(group)
                    .ConvertAll(p => new HubPost()
                    {
                        Message = p.Content,
                        UserName = p.Creator.Fullname,
                        UserEmail = p.Creator.Email,
                        Created = p.Created
                    });
        }

        public List<HubPost> GetPostsOfGroup(Guid guid)
        {
            Group group = _roomInfo[guid];
            return _notFakeService.Post.GetPosts(group)
            .ConvertAll(p => new HubPost()
            {
                Message = p.Content,
                Created = p.Created,
                UserEmail = p.Creator.Email,
                UserName = p.Creator.Fullname
            });
        }

        public List<HubUser> GetMemberOfGroup(Guid guid)
        {
            Group group = _roomInfo[guid];
            return _notFakeService.GroupMembers.GetGroupMembers(group)
                        .ConvertAll(mb => new HubUser()
                        {
                            UserEmail = mb.Member.Email,
                            UserName = mb.Member.Fullname,
                            IsOnline = _listConnectedUsers.ContainsValue(mb.Member)
                        });
        }

        // public List<HubUser> GetGroupFriendSuggestions(string keywords)
        // {
            
        // }

        // public Task<Guid> GetRoomForFilmId(string filmId)
        // {
        //     var foundRoom = _roomInfo.FirstOrDefault(
        //         x => x.Value.RoomFilmID == filmId);

        //     if (foundRoom.Key == Guid.Empty)
        //     {
        //         return null;
        //     }
        //     else
        //     {
        //         return Task.FromResult(foundRoom.Key);
        //     }
        // }

        // public Task<Guid> GetRoom(Guid groupName)
        // {
        //     var room = _roomInfo[groupName];

        // }

        public void Dispose()
        {
            _scope?.Dispose();
        }
    }
}
