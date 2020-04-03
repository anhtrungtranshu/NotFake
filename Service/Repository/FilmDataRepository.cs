using DAO;
using DAO.Models;
using Service.IRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class FilmDataRepository : RepositoryBase<FilmData>, IFilmDataRepository
    {
        private HttpClient _httpClient;

        public FilmDataRepository(NotFakeContext context) : base(context)
        {
            _httpClient = new HttpClient();
        }

        public async Task<Stream> GetVideoByFilmId(int filmId, int episode)
        {
            FilmData _filmData = context.FilmData.Find(episode, filmId);
            return await _httpClient.GetStreamAsync(_filmData.Address);
        }

    }
}
