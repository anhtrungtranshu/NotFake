using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotFake.Models
{
    public class ProfileViewModel
    {
        public string Email { get; set; }

        public string Fullname { get; set; }

        public virtual List<Friendship> Friends
        {
            get; set;
            // get
            // {
            //     var friends = SentFriendRequests.Where(x => x.Status == FriendShipStatus.Accepted).ToList();
            //     friends.AddRange(ReceievedFriendRequests.Where(x => x.Accepted));
            //     return friends;
            // }
        }

    }
}
