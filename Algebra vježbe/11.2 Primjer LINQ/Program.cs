using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._2_Primjer_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ OSOBE");
            List<Osoba> osobe = new List<Osoba>(); // kolekcija svih osoba upisana u seminar
            osobe.Add(new Osoba { Ime = "Mirko", Prezime = "Spirko" });
            osobe.Add(new Osoba { Ime = "Jura", Prezime = "Klafura" });
            osobe.Add(new Osoba { Ime = "Žarko", Prezime = "Žmarko" });
            osobe.Add(new Osoba { Ime = "Dana", Prezime = "Banana" });

            // Klasičan način pretrage bet LINQ-a
            Osoba trazenaOsoba = new Osoba();
            foreach (Osoba os in osobe)
            {
                //provjeravamo svojstvo Prezime za svakog člana kolekcije
                if (os.Prezime == "Spirko")
                {
                    trazenaOsoba = os;
                }
            }
            Console.WriteLine(trazenaOsoba.Prezime);

            // Koristeći LINQ upit

            Osoba trazenaOsobaLINQ_Prezime = new Osoba();
            trazenaOsobaLINQ_Prezime = (
                from o in osobe
                where o.Prezime == "Spirko"
                select o).SingleOrDefault();

            Console.WriteLine(trazenaOsobaLINQ_Prezime.Prezime);

            Osoba trazenaOsobaLINQ_Ime = new Osoba();
            trazenaOsobaLINQ_Ime = (
                from o in osobe
                where o.Ime == "Žarko"
                select o).SingleOrDefault();

            Console.WriteLine(trazenaOsobaLINQ_Ime.Ime);

            var trazeneOsobe = (
                from o in osobe
                where o.Ime.Contains ("rk")
                select o.Ime).ToList();

            foreach (var item in trazeneOsobe)
            {
                Console.WriteLine(item);
            }

            List<Osoba> osobePoRedu = (
                from os in osobe
                orderby os.Prezime descending
                where os.Prezime == "Spirko" || os.Prezime.Contains("Klaf")
                select os).ToList();

            foreach (var item in osobePoRedu)
            {
                Console.WriteLine(item.Ime);
            }
        }
    }
}
