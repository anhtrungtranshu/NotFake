using DAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IFriendshipRepository : IRepositoryBase<Friendship>
    {
        Friendship Get(int invitedUserId, int invitingUserId);
        List<Friendship> GetFriendships(User user, bool takePending);
        List<Friendship> GetFriendships(User user, string keyword, bool takePending);
        List<User> GetFriendSuggestions(User user, string keyword);
        int ChangeFriendship(User invitingUser, User invitedUser, bool isAccepted);
    }
}
