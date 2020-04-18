using DAO;
using DAO.Models;
using Microsoft.EntityFrameworkCore;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class FriendshipRepository : RepositoryBase<Friendship>, IFriendshipRepository
    {
        public FriendshipRepository(NotFakeContext context) : base(context) { }

        public Friendship Get(int invitedUserId, int invitingUserId)
        {
            // return context.Friendships.AsNoTracking()
            // .Where(fs => fs.InvitedUserId == invitedUserId && fs.InvitingUserId == invitingUserId)
            // .FirstOrDefault();
            return context.Friendships.Find(invitedUserId, invitingUserId);
        }

        public List<Friendship> GetFriendships(User user, string keyword, bool takePending)
        {
            return context.Friendships.Where(
                fs => (fs.InvitingUser == user || fs.InvitedUser == user)
                && (takePending ? fs.Status != FriendShipStatus.Rejected : fs.Status == FriendShipStatus.Accepted)
                && fs.InvitingUser == user ? (fs.InvitedUser.Email.Contains(keyword) || fs.InvitedUser.Fullname.Contains(keyword))
                : (fs.InvitingUser.Email.Contains(keyword) || fs.InvitingUser.Fullname.Contains(keyword))
            ).ToList();
        }

        public List<Friendship> GetFriendships(User user, bool takePending)
        {
            return context.Friendships.Where(
                fs => (fs.InvitingUser == user || fs.InvitedUser == user)
                && (takePending ? (fs.Status != FriendShipStatus.Rejected) : (fs.Status == FriendShipStatus.Accepted))
            ).ToList();
        }

        public List<User> GetFriendSuggestions(User user, string keyword)
        {
            List<Friendship> previousConnections = GetFriendships(user, false);

            return context.User.Where(
                u => u != user
                && (u.Email.Contains(keyword) || u.Fullname.Contains(keyword))
                && previousConnections.All(fs => fs.InvitedUser != u && fs.InvitingUser != u)
            ).ToList();
        }

        public int ChangeFriendship(User invitingUser, User invitedUser, bool isAccepted)
        {
            Friendship _friendship = Get(invitedUser.UserId, invitingUser.UserId);
            _friendship.Status = isAccepted ? FriendShipStatus.Accepted : FriendShipStatus.Rejected;
            return Update(_friendship);
        }

    }
}
