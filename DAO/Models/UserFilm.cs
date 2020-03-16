using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilm
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Film")]
        public int FilmId { get; set; }
        int SecondsWatched { get; set; }
    }
}
