using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface INotFakeService
    {
        IUserRepository User { get; set; }

        IGenreRepository Genre { get; set; }

        IGenreRepository FilmsInGenre { get; set; }
    }
}
