using System;
using System.Collections.Generic;
using System.Text;

namespace Generička_Lista_Hrvatska__98
{
    class Osoba
    {
        public Osoba (string ime, string prezime, string klub)
        {
            Ime = ime;
            Prezime = prezime;
            Klub = klub;
        }
        string ime;
        string prezime;
        string klub;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Klub { get => klub; set => klub = value; }
    }
}
