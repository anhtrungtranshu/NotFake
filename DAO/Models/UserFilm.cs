using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilm
    {
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int FilmId { get; set; }
        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }
        public int? SecondsWatched { get; set; }
    }
}
