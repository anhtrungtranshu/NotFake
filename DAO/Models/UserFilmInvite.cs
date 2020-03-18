using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public enum UserFilmInviteStatus
    {
        Pending,
        Accepted,
        Rejected
    }

    public class UserFilmInvite
    {
        public int InvitingUserId { get; set; }
        [ForeignKey("InvitingUserId")]
        public virtual User InvitingUser { get; set; }
        public int InvitedUserId { get; set; }
        [ForeignKey("InvitedUserId")]
        public virtual User InvitedUser { get; set; }
        public int FilmId { get; set; }
        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }
        public DateTime WatchDate { get; set; }
        public DateTime Created { get; set; }
        public UserFilmInviteStatus isAccepted { get; set; }
    }
}
