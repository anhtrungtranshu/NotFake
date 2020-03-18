﻿using DAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.IRepository
{
    public interface IGenreRepository: IRepositoryBase<Genre>
    {
        IList<Film> FilmsInGenre(int id);
    }
}
