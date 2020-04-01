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
        public List<Film> Films { get; set; }
    }
}
