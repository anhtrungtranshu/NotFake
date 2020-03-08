using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class UserFilmInvite
    {
        [Key]
        [ForeignKey("User")]
        int User1ID { get; set; }
        [Key]
        [ForeignKey("User")]
        int User2ID { get; set; }
        [Key]
        [ForeignKey("Film")]
        int FilmID { get; set; }
        [Key]
        DateTime WatchDate { get; set; }
        [Required]
        DateTime Created { get; set; }
        [Required]
        Boolean isAccepted { get; set; }


    }
}
