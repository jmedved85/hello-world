﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC2021.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)] // Anotacija
        public DateTime ReleaseDate { get; set; } // ovaj podatak će se prikazati kao Date zbog anotacije, ne mora se unositi sat (samo datum se prikazuje)
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
