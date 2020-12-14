using System;

namespace _7._2._8_Faktorijel
{
    class Program
    {
        // Program koji za uneseni prirodni broj računa faktorijel
        static void Main()
        {
            char ponovo = 'd';
            while (ponovo == 'D' || ponovo == 'd')
            {
                Console.WriteLine("Unesite prirodan broj: ");
                int broj = int.Parse(Console.ReadLine());
                Console.WriteLine("Faktorijel od {0} jest (n!): {1}", broj, Faktorijel(broj));
                Console.WriteLine("Želite li ponovno (D/N)?");
                ponovo = Console.ReadKey().KeyChar;
            }

            static long Faktorijel(int broj)
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
}
