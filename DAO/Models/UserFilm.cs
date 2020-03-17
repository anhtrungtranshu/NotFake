using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilm
    {
        public int UserFilmID { get; set; }
        [ForeignKey("Film")]
        public int FilmId { get; set; }
        public int SecondsWatched { get; set; }
    }
}
