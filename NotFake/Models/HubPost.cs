using System;

namespace NotFake.Models
{
    public class HubPost
    {
        public string Message { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime Created { get; set; }
    }
}