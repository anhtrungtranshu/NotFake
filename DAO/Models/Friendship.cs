using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class Friendship
    {
        
        [ForeignKey("User")]
        public int User1ID { get; set; }
        [ForeignKey("User")]
        public int User2ID { get; set; }
        [Required]
        string status { get; set; }
    }
}