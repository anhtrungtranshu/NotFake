using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Service.Repository
{
    public class FilmRepository : RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(NotFakeContext context) : base(context)
        {
        }

        public Film LoadFilmData(Film film)
        {
            context.Entry(film)
            .Collection(f => f.FilmData)
            .Load();
            return film;
        }
    }
}
