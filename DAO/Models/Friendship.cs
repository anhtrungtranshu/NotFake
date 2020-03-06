using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class Friendship
    {
        [Key]
        [ForeignKey("User")]
        int User1ID { get; set; }
        [Key]
        [ForeignKey("User")]
        int User2ID { get; set; }
        [Required]
        string status { get; set; }
    }
}