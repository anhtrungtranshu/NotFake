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

        public KeyValuePair<string, User> GetConnectedUser(string userEmail)
        {
            return _listConnectedUsers.Where(u => u.Value.Email == userEmail).FirstOrDefault();
        }

        public KeyValuePair<string, User> GetConnectedUser(User user)
        {
            return _listConnectedUsers.Where(u => u.Value == user).FirstOrDefault();
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
        public KeyValuePair<Guid, Group> GetGroup(Group group)
        {
            return _roomInfo.Where(r => r.Value == group).FirstOrDefault();
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

        public List<HubUser> GetUserFriendList(string email, string keyword)
        {
            User _user = _notFakeService.User.GetByEmail(email);
            List<Friendship> _friendship = keyword == "" ? _notFakeService.Friendship.GetFriendships(_user, false)
            : _notFakeService.Friendship.GetFriendships(_user, keyword, false);

            return _friendship.ConvertAll(fs => new HubUser()
            {
                UserEmail = fs.InvitingUser == _user ? fs.InvitedUser.Email : fs.InvitingUser.Email,
                UserName = fs.InvitingUser == _user ? fs.InvitedUser.Fullname : fs.InvitingUser.Fullname
            });
        }

        public List<HubUser> GetFriendSuggestions(string email, string keyword)
        {
            User _user = _notFakeService.User.GetByEmail(email);
            return _notFakeService.Friendship.GetFriendSuggestions(_user, keyword)
                        .ConvertAll(u => new HubUser()
                        {
                            UserEmail = u.Email,
                            UserName = u.Fullname
                        });
        }

        public KeyValuePair<string, User> AddFriendRequest(string email, string requestToEmail)
        {
            try
            {
                User invitingUser = _notFakeService.User.GetByEmail(email);
                User invitiedUser = _notFakeService.User.GetByEmail(requestToEmail);

                _notFakeService.Friendship.Add(new Friendship()
                {
                    InvitingUser = invitingUser,
                    InvitedUser = invitiedUser,
                    Status = FriendShipStatus.Pending
                });
                return GetConnectedUser(invitiedUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<HubUser> GetGroupFriendSuggestion(string email, string keyword)
        {
            try
            {
                User currentUser = _notFakeService.User.GetByEmail(email);
                return _notFakeService.Friendship.GetFriendships(currentUser, keyword, false)
                                    .Where(fs => fs.InvitedUser == currentUser ? _listConnectedUsers.ContainsValue(fs.InvitingUser)
                                    : _listConnectedUsers.ContainsValue(fs.InvitedUser))
                                    .ToList()
                                    .ConvertAll(fs => new HubUser()
                                    {
                                        UserEmail = fs.InvitedUser == currentUser ? fs.InvitingUser.Email : fs.InvitedUser.Email,
                                        UserName = fs.InvitedUser == currentUser ? fs.InvitingUser.Fullname : fs.InvitedUser.Fullname
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserFilmInvite AddFilmInvitation(string groupName, string invitedUserEmail)
        {
            try
            {
                Group group = _roomInfo
                                        .Where(r => r.Key.ToString() == groupName)
                                        .FirstOrDefault()
                                        .Value;
                User invitedUser = _notFakeService.User.GetByEmail(invitedUserEmail);

                UserFilmInvite invitation = _notFakeService.UserFilmInvite.Add(new UserFilmInvite()
                {
                    Group = group,
                    InvitedUser = invitedUser,
                    isAccepted = UserFilmInviteStatus.Pending
                });

                return invitation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserFilmInvite FilmInvitationHandle(int invitationId, string invitedUserEmail, bool isAccepted)
        {
            try
            {
                UserFilmInvite invitation = _notFakeService.UserFilmInvite.Get(invitationId);
                invitation.isAccepted = isAccepted ? UserFilmInviteStatus.Accepted : UserFilmInviteStatus.Rejected;
                _notFakeService.UserFilmInvite.Update(invitation);
                return invitation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public void AddMemberToGroup(Group group, string invitedUserEmail)
        {
            try
            {
                User invitedUser = _notFakeService.User.GetByEmail(invitedUserEmail);
                _notFakeService.GroupMembers.Add(new GroupMembers()
                {
                    Group = group,
                    Member = invitedUser
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            _scope?.Dispose();
        }
    }
}
