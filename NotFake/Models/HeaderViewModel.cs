using System.Collections.Generic;

namespace NotFake.Models
{
    public class HeaderViewModel
    {
        public HubUser currentUser { get; set; }
        public List<HubUser> friendRequests { get; set; }
    }
}