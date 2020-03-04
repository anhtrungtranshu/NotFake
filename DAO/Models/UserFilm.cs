using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilm
    {
        [Key]
        [ForeignKey("User")]

        public int Id { get; set; }

        [Key]
        [ForeignKey("Film,")]

        public int FilmId { get; set; }

        int SecondWatched { get; set; }
    }
}
