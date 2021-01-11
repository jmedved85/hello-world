using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._1._3_Automobili
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AUTOMOBILI");
            List<Automobil> auti = new List<Automobil>(); // formiranje glavne liste
            string unos = "".ToLower();
            while (unos !="n") // dokle god nije unos n za izlaz
            {
                auti.Add(Automobil.UnosAutomobila()); // dodavanje automobila sa svojstvima (Marka, Model, Zapremina) u glavnu listu preko posebne metode za unos (UnosAutomobila())
                Console.WriteLine("Želite li upisati novi automobil (d/n)?");
                unos = Console.ReadLine();
            }     
            Console.WriteLine();
            Console.WriteLine("Svi automobili");
            foreach (var item in auti) // Ispis svih unešenih automobila (bez izlistane zapremine)
            {
                Console.WriteLine($"{item.Marka} {item.Model}");
            }

            // Upit za ispis modela velike zapremine
            List<string> modeliVelikeZapremine = (from auto in auti // vade se objekti iz glavne liste
                                                  orderby auto.Model // poredati po nazivu modela
                                                  where auto.Zapremina > 1600 // gdje su objekti veći od 1600
                                                  select auto.Model).ToList(); // izbacije se objekt po nazivu modela
            Console.WriteLine();
            Console.WriteLine("Pronađeni modeli velike zapremine su:");
            foreach (string model in modeliVelikeZapremine)
            {
                Console.WriteLine(model); // ispis
            }


        }
    }
}
