using DAO.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service.IRepository
{
    public interface IFilmDataRepository : IRepositoryBase<FilmData>
    {
        Task<Stream> GetVideoByFilmId(int filmId, int episode);
    }
}
