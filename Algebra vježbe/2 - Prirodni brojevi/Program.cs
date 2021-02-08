using System;
using System.Collections.Generic;

namespace _2___Prirodni_brojevi
{
    // Jasmin Medved
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Unesite prirodne brojeve (sve dok ne unesete '0'): ");
            Console.ResetColor();
            int broj = int.MaxValue;
            List<int> listaBrojeva = new List<int>();
            List<int> lista2I3 = new List<int>();
            List<int> lista2NE3 = new List<int>();
            List<int> lista3NE2 = new List<int>();
            List<int> listaOstali = new List<int>();

            while (broj != 0)
            {
                int.TryParse(Console.ReadLine(), out broj);
                listaBrojeva.Add(broj);
                if (broj % 2 == 0 && broj % 3 == 0 && broj != 0)
                {
                    lista2I3.Add(broj);
                }
                else if (broj % 2 == 0 && !(broj % 3 == 0) && broj != 0)
                {
                    lista2NE3.Add(broj);
                }
                else if (broj % 3 == 0 && !(broj % 2 == 0) && broj != 0)
                {
                    lista3NE2.Add(broj);
                }
                else if (broj != 0)
                {
                    listaOstali.Add(broj);
                }
            }            
            Console.WriteLine("--------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Svi unešeni brojevi: ");
            Console.ResetColor();

            listaBrojeva.Sort(); lista2I3.Sort(); lista2NE3.Sort(); listaOstali.Sort();

            foreach (int item in listaBrojeva)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Brojevi djeljivi s 2 i s 3: ");
            Console.ResetColor();
            foreach (int item in lista2I3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Brojevi djeljivi s 2 (ali ne s 3): ");
            Console.ResetColor();
            foreach (int item in lista2NE3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Brojevi djeljivi s 3 (ali ne s 2): ");
            Console.ResetColor();
            foreach (int item in lista3NE2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ostali brojevi:  ");
            Console.ResetColor();
            foreach (int item in listaOstali)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
