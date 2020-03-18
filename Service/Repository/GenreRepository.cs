using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repository
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        private NotFakeContext context;
        public GenreRepository(NotFakeContext context) : base(context) { }

        public IList<Film> FilmsInGenre(Genre genre)
        {
            return genre.Films;
        }
    }
    
}
