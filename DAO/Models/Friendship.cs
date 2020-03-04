using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    public class Friendship
    {
        [Key]
        int User1ID { get; set; }
        [Key]
        int User2ID { get; set; }
        string status { get; set; }
    }
}
