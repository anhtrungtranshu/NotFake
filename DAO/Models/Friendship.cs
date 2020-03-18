using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class Friendship
    {
        
        //[ForeignKey("User1")]
        public int User1Id { get; set; }
        public User User1 { get; set; }

        //[ForeignKey("User2")]
        public int User2Id { get; set; }
        public User User2 { get; set; }

        [Required]
        public string status { get; set; }
    }
}