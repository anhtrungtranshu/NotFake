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
            Friendship = new FriendshipRepository(context);
            Post = new PostRepository(context);
            UserFilmInvite = new UserFilmInviteRepository(context);
            Genre = new GenreRepository(context);
            Film = new FilmRepository(context);
            FilmsInGenre = new GenreRepository(context);

        }
        public IFilmRepository Film { get; set; }
        public IFriendshipRepository Friendship { get; set; }
        public IGenreRepository Genre { get; set; }
        public IPostRepository Post { get; set; }
        public IUserFilmInviteRepository UserFilmInvite { get; set; }
        public IUserFimRepository UserFilm { get; set; }
        public IUserRepository User { get; set; }
        public IGenreRepository FilmsInGenre { get; set; }
    }
}
