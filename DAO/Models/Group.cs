using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? FilmId { get; set; }
        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }
        public int? CreatorId { get; set; }
        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }
        public DateTime Created { get; set; }
    }
}