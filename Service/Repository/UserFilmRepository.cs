using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repository
{
    class UserFilmRepository : RepositoryBase<UserFilm>, IUserFimRepository
    {
        public UserFilmRepository(NotFakeContext context) : base(context) { }

    }
}
    