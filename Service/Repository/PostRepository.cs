using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(NotFakeContext context) : base(context) { }

        public List<Post> GetPosts(Group group)
        {
            return context.Posts.Where(p => p.Group == group).ToList();
        }
        public List<Post> GetPosts(User user)
        {
            return context.Posts.Where(p => p.Creator == user).ToList();
        }
    }
}
