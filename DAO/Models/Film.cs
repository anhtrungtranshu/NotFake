using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAO.Models
{
    public class Film
    {
        [Key]
        int FilmId { get; set; }
        string Name { get; set; }
        int RunTime { get; set; }
        string FilmAddress { get; set; }

        [ForeignKey("Genre")]
        public int GenreID { get; set; }

    }
}
