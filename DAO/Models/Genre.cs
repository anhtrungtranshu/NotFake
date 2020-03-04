﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAO.Models
{
    class Genre
    {
        [Key]
        int GenreId { get; set; }
        string Name { get; set; }
    }
}
