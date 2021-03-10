using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [DataType(DataType.Date)]
        public DateTime? Datum { get; set; }
        public int IdZaposlenik { get; set; }
        public bool? Popunjen { get; set; }

        public virtual ICollection<Predbiljezba> Predbiljezbas { get; set; }
        public virtual Zaposlenik IdZaposlenikNavigation { get; set; }
    }
}
