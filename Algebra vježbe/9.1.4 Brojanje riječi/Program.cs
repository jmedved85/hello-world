using System;
using System.Collections.Generic;

namespace _9._1._4_Brojanje_riječi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RIJEČ U REČENICI");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite rečenicu: ");
                string recenica = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova                              

                int brojac = 0; // Deklaracija integera za brojanje

                List<string> rijeci = new List<string>(recenica.Split(' '));

                foreach (var item in rijeci)
                {
                    brojac++;
                }
                Console.WriteLine($"Rečenica '{recenica}' ima {brojac} riječi.");

                Console.Write("Želite li dalje (D/N)? ");
                dalje = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }                
            
        }
    }
}
