using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(NotFakeContext context) : base(context) { }

    }
}
