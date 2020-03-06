using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class Post
    {
        [Key]
        [ForeignKey("User")]
        int User1ID { get; set; }
        [Key]
        [ForeignKey("User")]
        int User2ID { get; set; }
        [Required]
        string Content { get; set; }
        [Required]
        DateTime Created { get; set; }
    }
}
