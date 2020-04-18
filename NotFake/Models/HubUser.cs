using System.Collections.Generic;
using DAO.Models;

namespace NotFake.Models
{
    public class HubUser
    {
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public bool? IsOnline { get; set; }
    }
}