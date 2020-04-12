using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public class GroupMembers
    {
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public User Member { get; set; }
    }
}