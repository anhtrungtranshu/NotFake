using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}
