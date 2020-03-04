using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    public class Post
    {
        [Key]
        int User1ID {get;set;}
        [Key]
        int User2ID { get; set; }
        string Content { get; set; }
        DateTime Created { get; set; }
    }
}
