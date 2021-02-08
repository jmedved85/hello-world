using System;

namespace _6._1._2_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] niz = new int[5];
            Console.WriteLine("Unesite 5 prirodnih brojeva:");
            for (int i = 0; i < niz.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out niz[i]);
            }
            int max = niz[0];
            for (int i = 1; i < niz.Length; i++)
            {
                if (niz [i] > max)
                {
                    max = niz[i];
                }
            }

            Console.WriteLine("Ispis:");

            for (int i = 0; i < niz.Length; i++)
            {
                if (max == niz[i])
                {
                   Console.ForegroundColor = ConsoleColor.Red;
                }
                
                Console.WriteLine(niz[i]); Console.ResetColor();
            }


        }
    }
}
