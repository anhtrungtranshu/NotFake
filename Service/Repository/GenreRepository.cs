using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        
        public GenreRepository(NotFakeContext context) : base(context) { }

        public IList<Film> FilmsInGenre(int id)
        {
            Genre genre = context.Genre.Find(id);
            return genre.Films.ToList();
        }
    }
    
}
