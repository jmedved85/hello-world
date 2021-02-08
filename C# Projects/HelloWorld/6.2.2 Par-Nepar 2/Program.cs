using System;
using System.Collections.Generic;

namespace _6._2._2_Par_Nepar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sviBrojevi = new List<int>();
            List<int> neparniBrojevi = new List<int>();
            List<int> parniBrojevi = new List<int>();

            Console.WriteLine("Unesite 10 prirodnih brojeva:");
            for (int i = 0; i < 10; i++)
            {
                int.TryParse(Console.ReadLine(), out int broj);
                if (broj % 2 == 0)
                {
                    parniBrojevi.Add(broj);
                }
                else
                {
                    neparniBrojevi.Add(broj);
                }
                sviBrojevi.Add(broj);
            }

            Console.WriteLine("Ispis svih brojeva:");
            sviBrojevi.Sort();
            foreach (var item in sviBrojevi)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

            Console.WriteLine("Ispis parnih brojeva:");
            parniBrojevi.Sort();
            foreach (var item in parniBrojevi)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();

            Console.WriteLine("Ispis neparnih brojeva:");
            neparniBrojevi.Sort();
            foreach (var item in neparniBrojevi)
            {
                Console.Write($" {item}");
            }
        }
    }
}
