using System;

namespace _6._1._1_Unos_ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[10];
            Console.WriteLine("Unesite 10 prirodnih brojeva!");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}. broj: ");
                niz[i-1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ispis brojeva:");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.Write($"{niz[i]}, ");
            }
        }
    }
}
