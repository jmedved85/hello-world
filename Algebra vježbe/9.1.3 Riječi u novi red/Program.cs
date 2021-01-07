using System;
using System.Collections.Generic;

namespace _9._1._3_Riječi_u_novi_red
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RIJEČi U NOVI RED");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite rečenicu: ");
                string recenica = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova

                // Pomoću običnog niza
                //string[] rijeci = recenica.Split();
                //foreach (var item in rijeci)
                //{
                //    Console.WriteLine(item.ToUpper());
                //}

                // Pomoću liste
                List<string> rijeci = new List<string>(recenica.Split(' '));

                foreach (var item in rijeci)
                {
                    Console.WriteLine(item.ToUpper());
                }

                // Pomoću substringa
                //foreach (char c in recenica)
                //{
                //    if (c != ' ')
                //    {
                //        Console.Write(c);
                //    }
                //    else
                //    {
                //        Console.WriteLine();
                //    }
                //}

                Console.Write("Želite li dalje (D/N)? ");
                dalje = Console.ReadKey().KeyChar;
                Console.WriteLine();

            }
        }
    }
}
