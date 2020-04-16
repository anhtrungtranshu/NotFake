using DAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IFriendshipRepository : IRepositoryBase<Friendship>
    {
        List<Friendship> GetFriendships(User user);
        List<Friendship> GetFriendships(User user, string keyword);
    }
}
