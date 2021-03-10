using System;
using System.Collections.Generic;

#nullable disable

namespace BazaSeminari.Models
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
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Seminar> Seminars { get; set; }
    }
}
