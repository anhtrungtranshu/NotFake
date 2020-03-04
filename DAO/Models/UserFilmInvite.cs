using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    public class UserFilmInvites
    {
        [Key]
        int User1ID { get; set; }
        [Key]
        int User2ID {get;set;}
        [Key]
        int FilmID { get; set; }
        [Key]
        DateTime WatchDate { get; set; }
        DateTime Created { get; set; }
        Boolean isAccepted { get; set; }


    }
}
