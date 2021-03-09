﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BazaSeminari.Models
{
    public partial class Seminar
    {
        public Seminar()
        {
            Predbiljezbas = new HashSet<Predbiljezba>();
        }

        public int IdSeminar { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public bool? Popunjen { get; set; }

        public virtual ICollection<Predbiljezba> Predbiljezbas { get; set; }
    }
}
