using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public enum FriendShipStatus
    {
        Pending,
        Accepted,
        Rejected
    }

    public class Friendship
    {   
        public int InvitingUserId { get; set; }
        [ForeignKey("InvitingUserId")]
        public virtual User InvitingUser { get; set; }
        public int InvitedUserId { get; set; }
        [ForeignKey("InvitedUserId")]
        public virtual User InvitedUser { get; set; }
        public FriendShipStatus Status { get; set; }
    }
}