﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAO.Models
{
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int RunTime { get; set; }
        [Required]
        public string FilmAddress { get; set; }

    }
}
