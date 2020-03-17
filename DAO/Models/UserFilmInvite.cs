using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilmInvite
    {
        public int UserFilmInviteID { get; set; }
        [ForeignKey("Film")]
        public int FilmID { get; set; }
        public DateTime WatchDate { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public Boolean isAccepted { get; set; }


    }
}
