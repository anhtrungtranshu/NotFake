using DAO;
using DAO.Models;
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

        public List<Friendship> GetFriendships(User user, string keyword)
        {
            return context.Friendships.Where(
                fs => fs.InvitingUser == user
                && fs.Status == FriendShipStatus.Accepted
                && (fs.InvitedUser.Email.Contains(keyword)
                || fs.InvitedUser.Fullname.Contains(keyword)
            )).ToList();
        }
    }
}
