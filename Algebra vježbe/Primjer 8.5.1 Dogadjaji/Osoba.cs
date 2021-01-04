using System;
using System.Collections.Generic;
using System.Text;

namespace Primjer_8._5._1_Dogadjaji
{
    public class Osoba
    {
        // Deklaracija događaja
        // Delegat - pokazivač na preusmjeravanje izvođenja programa iz klase u glavnom programu
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;
        // Svojstva
        private string ime;

        public string Ime
        {
            get { return ime; }
            set // PODIZANJE DOGAĐAJA
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
    }
}
