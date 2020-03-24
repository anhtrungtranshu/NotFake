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
        private HttpClient _httpClient;

        public FilmRepository(NotFakeContext context) : base(context)
        {
            _httpClient = new HttpClient();
        }

        public async Task<Stream> GetVideoByFilmId(int id)
        {
            Film film = Get(id);
            return await _httpClient.GetStreamAsync(film.FilmAddress);
        }
    }
}
