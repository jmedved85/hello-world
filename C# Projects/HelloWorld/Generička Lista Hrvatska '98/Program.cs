using System;
using System.Collections.Generic;

namespace Generička_Lista_Hrvatska__98
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite ime i prezime reprezentativaca i njihov klub:");
            List<Osoba> reprezentativci = new List<Osoba>();

            Osoba osoba1 = new Osoba("Robert", "Prosinečki", "Dinamo");
            Osoba osoba2 = new Osoba("Robert", "Jarni", "Real Madrid");
            Osoba osoba3 = new Osoba("Mario", "Stanić", "Parma");
            Osoba osoba4 = new Osoba("Zvonimir", "Soldo", "Stuttgart");
            

            reprezentativci.Add(osoba1); reprezentativci.Add(osoba2); reprezentativci.Add(osoba3); reprezentativci.Add(osoba4);

            foreach (Osoba item in reprezentativci)
            {
                Console.WriteLine(item);
            }



        }
    }
}
