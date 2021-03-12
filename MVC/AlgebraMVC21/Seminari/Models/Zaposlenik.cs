using System;
using System.Collections.Generic;

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
        public string Password { get; set; }

        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}
