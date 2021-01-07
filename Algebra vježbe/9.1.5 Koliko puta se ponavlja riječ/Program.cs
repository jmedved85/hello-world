using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._1._5_Koliko_puta_se_ponavlja_riječ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOLIKO PUTA SE PONAVLJA RIJEČ");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite rečenicu: ");
                string recenica = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova                              

                List<string> rijeci = new List<string> (recenica.Split('.', '?', '!', ' ', ';', ':', ','));

                int brojac = rijeci.Count();                
                
                Console.WriteLine($"Rečenica '{recenica}' ima {brojac} riječi.");

                Console.Write("Želite li dalje (D/N)? ");
                dalje = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }
    }
}
