using System;

namespace _7._2._6_Prost_broj
{
    /* Program koji u funkciji ispituje je li uneseni prirodan broj
     * prost ili složen (broj je prost ako je djeljiv s 1 i sa samim
     * sobom. */
    class Program
    {
        static void Main()
        {
            char ponovo = 'd';
            while (ponovo == 'D' || ponovo == 'd')
            {
                Console.WriteLine("Unesite prirodan broj: ");
                int broj = int.Parse(Console.ReadLine());
                if (Funkcija(broj))
                {
                    Console.WriteLine("Broj je prost.");
                }
                else
                {
                    Console.WriteLine("Broj je složen.");
                }
                Console.WriteLine("Želite li ponovno (D/N)?");
                ponovo = Console.ReadKey().KeyChar;
            }         
        }

        private static bool Funkcija(int broj)
        {
            bool odgovor = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    odgovor = false;
                    break;
                }                
            }
            return odgovor;
        }
    }
}
