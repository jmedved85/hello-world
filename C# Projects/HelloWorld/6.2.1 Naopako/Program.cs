using System;
using System.Collections.Generic;

namespace _6._2._1_Naopako
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();
            Console.WriteLine("Upišite 5 imena:");
            for (int i = 1; i <= 5; i++)
            {
                string ime = Console.ReadLine();
                imena.Add(ime);
            }
            imena.Sort();
            Console.WriteLine();
            Console.WriteLine("Sortirani ispis:");
            foreach (var item in imena)
            {
                if (item == "slađana".ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Nju ja VOLIM!!! -> ");
                }
                Console.WriteLine(item); Console.ResetColor();
            }
        }
    }
}
