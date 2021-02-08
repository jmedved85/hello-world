using System;

namespace _7._2._8_Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "D";
            while (izbor == "D" || izbor == "d")
            {
                Console.Write("Unesite prirodan broj: ");
                int.TryParse(Console.ReadLine(), out int broj);
                Console.WriteLine("------------------------");
                Console.WriteLine($"Faktorijel od {broj} je {Faktorijel(broj)}!");
                Console.WriteLine("Želite li ponovno (D/N)?");
                izbor = Console.ReadLine();
            }
        }

        private static long Faktorijel(int broj)
        {
            long faktorijel = 1;
            for (int i = 1; i <= broj; i++)
            {
                faktorijel *= i;
            }
            return faktorijel;
        }
    }
}
