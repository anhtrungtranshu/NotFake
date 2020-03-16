using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(NotFakeContext context) : base(context) { }

        public User GetByEmail(string email)
        {
            return context.User.Where(user => user.Email == email).FirstOrDefault();            
        }
    }
}
