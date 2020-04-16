using DAO;
using DAO.Models;
using DAO.Utilities;
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
        public bool IsCorrectPassword(string email, string password)
        {
            User user = GetByEmail(email);
            if (user == null) return false;
            return Crypto.VerifyHashedPassword(user.Password, password);
        }

        public int UpdatePassword(string email, string password)
        {
            User user = GetByEmail(email);
            if (user == null) return -1;
            user.Password = Crypto.HashPassword(password);
            return Update(user);
        }



    }
}
