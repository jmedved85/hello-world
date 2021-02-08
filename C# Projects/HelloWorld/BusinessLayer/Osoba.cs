using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Osoba
    {
        // Konstruktor
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        // Svojstva ime i prezime
        private string ime;
        public string Ime { get => ime; set => ime = value; }

        private string prezime;
        public string Prezime { get => prezime; set => prezime = value; }

        // Metoda PunoIme
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
