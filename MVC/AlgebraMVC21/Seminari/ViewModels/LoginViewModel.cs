using Seminari.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seminari.ViewModels
{
    public class LoginViewModel : Zaposlenik
    {
        [Required(ErrorMessage = "Obavezan unos")]
        [DataType(DataType.Password)]
        [Display(Name = "Korisnik:")]
        public new string KorisnickoIme { get; set; }

        [Required(ErrorMessage = "Obavezan unos")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka:")]
        public new string Password { get; set; }

        [Display(Name = "Zapamti me")]
        public bool ZapamtiMe { get; set; }
    }
}
