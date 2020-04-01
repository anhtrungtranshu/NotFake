using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public enum FilmType
    {
        Movie,
        Series
    }
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ThumbnailAddress { get; set; }
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
        [Required]
        public FilmType Type { get; set; }
        public virtual List<FilmData> FilmData { get; set; }
    }
}
