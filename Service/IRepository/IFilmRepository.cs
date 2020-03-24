using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;
using DAO.Models;
using System.Threading.Tasks;

namespace Service.IRepository
{
     public interface IFilmRepository: IRepositoryBase<Film>
    {
        Task<Stream> GetVideoByFilmId(int id);
    }
}
