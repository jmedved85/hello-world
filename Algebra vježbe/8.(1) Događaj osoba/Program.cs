using System;

namespace _8._1__Događaj_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba();
            osoba1.Ime = "Vinko";
            
            osoba1.NaPromjenuImenaOsobe += new Osoba.NaPromjenuImenaOsobeDelegat(osoba_NaPromjenuImenaOsobe);
            
            osoba1.Ime = "Slavko";
            osoba1.Ime = "Mirko";

            osoba1.NaPromjenuImenaOsobe -= new Osoba.NaPromjenuImenaOsobeDelegat(osoba_NaPromjenuImenaOsobe);
            osoba1.Ime = "Ljupko";

            static void osoba_NaPromjenuImenaOsobe (object sender, EventArgs e)
            {
                Console.WriteLine("Osoba se sada zove {0}", ((Osoba)sender).Ime);
            }
        }
    }
}
