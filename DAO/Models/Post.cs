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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostID { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public int SentUserId { get; set; }
        [ForeignKey("SentUserId")]
        public virtual User SentUser { get; set; }
        public int ReceivedUserId { get; set; }
        [ForeignKey("ReceivedUserId")]
        public virtual User ReceivedUser { get; set; }
    }
}
