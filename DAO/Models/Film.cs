using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    class Film
    {
        private string FilmName;

        [Key]
        int Id { get; set; }
        
        public string Name {get; set;}



    }
}
