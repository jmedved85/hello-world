using System;
using System.Collections.Generic;
using System.Text;

namespace _3___Učenik
{
    // Jasmin Medved
    public class Ucenik
    {       
        string ime;
        string prezime;
        DateTime datumRodjenja;
        double prosjek;

        public delegate void NaPromjenuDatumaRodjenjaDelegat(object sender, EventArgs e, DateTime datumRodjenja);
        public event NaPromjenuDatumaRodjenjaDelegat NaPromjenuDatumaRodjenja;
        public Ucenik()
        {
        }
        public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.Prosjek = prosjek;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja {
            get { return datumRodjenja; }
            set
            {
                datumRodjenja = value;
                if (NaPromjenuDatumaRodjenja != null)
                {
                    NaPromjenuDatumaRodjenja(this, new EventArgs(), datumRodjenja);                    
                }                               
            }
        }
        public double Prosjek { get { return prosjek; } set => prosjek = value; }             

        public int Starost(DateTime datumRodjenja)
        {
            DateTime d = DateTime.Now;
            TimeSpan ts = d.Subtract(datumRodjenja);
            return ts.Days / 365;
        }

        public string ProsjekRijecima(double prosjek)
        {
            string pr = "";
            if (prosjek < 2)
            {
                pr = "nedovoljan";
            }
            else if (prosjek >= 2 && prosjek < 2.50)
            {
                pr = "dovoljan";
            }
            else if (prosjek >= 2.50 && prosjek < 3.50)
            {
                pr = "dobar";
            }
            else if (prosjek >= 3.50 && prosjek < 4.50)
            {
                pr = "vrlo dobar";
            }
            else
            {
                pr =  "odličan";
            }
            return pr;
        }

        public override string ToString()
        {
            return "Učenik: " + this.Ime + " " + this.Prezime + "\nDatum rođenja: " 
                + this.DatumRodjenja.ToLongDateString() +  "\nProsjek: " + ProsjekRijecima(this.Prosjek);
        }        
    }
}
