using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.Models
{
    public class MainPageViewModel
    {
        public Genre Genre { get; set; }
        public Film Film { get; set; }
    }
    
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual List<Film> Films { get; set; }
    }

    public class Film
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int RunTime { get; set; }
        public string FilmAddress { get; set; }
    }
}
