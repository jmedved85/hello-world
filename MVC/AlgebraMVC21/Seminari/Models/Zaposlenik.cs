using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Seminari.Models
{
    public partial class Zaposlenik 
    {
        public Zaposlenik()
        {
            Seminars = new HashSet<Seminar>();
        }
     
        public int IdZaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string ImePrezime { get => this.Ime + " " + this.Prezime; }

        public string KorisnickoIme { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}
