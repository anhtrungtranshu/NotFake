using DAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        List<Post> GetPosts(Group group);
        List<Post> GetPosts(User user);
    }
}
