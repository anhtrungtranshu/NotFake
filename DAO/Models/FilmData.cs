using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public class FilmData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int RunTime { get; set; } // in mins
        [Required]
        public string ThumbnailAddress { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int FilmId { get; set; }
        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }
    }
}