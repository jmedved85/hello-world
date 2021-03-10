using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Seminari.Models
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

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy.}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? Datum { get; set; }
        public bool? Popunjen { get; set; }

        [DisplayName("Predavač")]
        public int? IdZaposlenik { get; set; }

        public virtual Zaposlenik IdZaposlenikNavigation { get; set; }
        public virtual ICollection<Predbiljezba> Predbiljezbas { get; set; }
    }
}
