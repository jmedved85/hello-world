using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_8._3._1_Naljedjivanje
{
    public class Osoba
    {
        // Deklariranje događaja
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e); // Pokazivač na preusmjeravanje izvođenja programa iz klase u glavnom programu
        public event NaPromjenuImenaDelegat NaPromjenuImena; // Događaj
        // Konstruktor
        public Osoba()
        {

        }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        // Svojstva ime i prezime
        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs()); // Podizanje događaja
                }
            }
        }

        private string prezime;
        public string Prezime { get => prezime; set => prezime = value; }

        // Metoda PunoIme
        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
