using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;
using DAO.Models;


namespace Service.IRepository
{
     public interface IFilmRepository: IRepositoryBase<Film>
    {
    }
}
