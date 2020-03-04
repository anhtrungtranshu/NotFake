using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repository
{
    public class UserFilmInviteRepository : RepositoryBase<UserFilmInvite>, IUserFilmInviteRepository
    {
        public UserFilmInviteRepository(NotFakeContext context) : base(context) { }
    }
}
