using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public class Film
    {
        [Key]
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int RunTime { get; set; }
        public string FilmAddress { get; set; }

    }
}
