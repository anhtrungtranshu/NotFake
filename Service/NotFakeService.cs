using DAO;
using Service.IRepository;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class NotFakeService : INotFakeService
    {
        public NotFakeService(NotFakeContext context)
        {
            User = new UserRepository(context);

            Genre = new GenreRepository(context);

            FilmsInGenre = new GenreRepository(context);
        }
        public IUserRepository User { get; set; }

        public IGenreRepository Genre { get; set; }

        public IGenreRepository FilmsInGenre { get; set; }
    }
}
