using System.Collections.Generic;
using DAO.Models;

namespace NotFake.Models
{
    public class HubGroup
    {
        public string GroupName { get; set; }
        public List<HubPost> Posts { get; set; }
        public List<HubUser> Members { get; set; }

        public bool? isGroupAdmin { get; set; }
    }
}