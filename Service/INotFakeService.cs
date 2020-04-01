using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface INotFakeService
    {
        IUserRepository User { get; set; }
        IFriendshipRepository Friendship { get; set; }
        IPostRepository Post { get; set; }
        IUserFilmInviteRepository UserFilmInvite { get; set; }
        IGenreRepository Genre { get; set; }
        IFilmRepository Film { get; set; }
        IFilmDataRepository FilmData { get; set; }
    }
}
