using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1__Događaj_osoba
{
    class Osoba
    {
        string ime;

        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImenaOsobe != null)
                {
                    NaPromjenuImenaOsobe(this, new EventArgs());
                }
            }
        }

        public delegate void NaPromjenuImenaOsobeDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaOsobeDelegat NaPromjenuImenaOsobe;
    }
}
