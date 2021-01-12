using System;
using System.Collections.Generic;
using System.Text;

namespace _11._1._1_Rođendan
{
    public enum Spol { Muški, Ženski };
    class Osoba
    {
        private Spol spol;
        string ime;
        string prezime;
        DateTime datumRodjenja;
       // int starost;

        public Osoba (string ime, string prezime) // definirani konstruktor koji prima dva argumenta (ime i prezime)
        {
            this.ime = Ime;
            this.prezime = Prezime;

        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set
            {
                datumRodjenja = value;
                // Ako je nova vrijednost današnji datum, podiže se događaj
                if (datumRodjenja.ToString("dd MM") == DateTime.Now.ToString("dd MM"))
                {
                    Rodjendan(this, new EventArgs());
                }
            }
        }
        public int Starost
        {
            get
            {
                DateTime d = DateTime.Now;
                TimeSpan ts = d.Subtract(DatumRodjenja);
                return ts.Days / 365 ;
            }
        } // ReadOnly svojstvo
        public Spol Spol { get => spol; set => spol = value; }

        // Događaj
        public delegate void RodjendanDelegat(object sender, EventArgs e);
        public event RodjendanDelegat Rodjendan; 
    }
}
