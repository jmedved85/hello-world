using Seminari.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Seminari.ViewModels
{
    public class RegisterViewModel : Zaposlenik
    {
        [Required(ErrorMessage = "Obavezan unos")]
        [DataType(DataType.Password)]
        [Display(Name = "Korisnik:")]
        public new string KorisnickoIme { get; set; }

        [Required(ErrorMessage = "Obavezan unos")]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka:")]
        public new string Password { get; set; }

        [Required(ErrorMessage = "Obavezan unos")]
        [DataType(DataType.Password)]
        [Display(Name = "Potvrdi unešenu lozinku:")]
        [Compare("Password", ErrorMessage = "Unešene lozinka i potvrda lozinke nisu ispravni")]
        public string ConfirmPassword { get; set; }
    }
}
