using System;

namespace _7._2._6_Prost_broj
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
                Console.WriteLine($"Broj {broj} je {ProstIliSlozen(broj)}!");
                Console.WriteLine("Želite li ponovno (D/N)?");
                izbor = Console.ReadLine();               
            }            
        }

        private static string ProstIliSlozen(int broj)
        {
            string odgovor = "";
            bool prostDa = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prostDa = false;
                    break;
                }               
            }
            if (prostDa)
            {
                odgovor = "prost";
            }
            else
            {
                odgovor = "složen";
            }
            return odgovor;
        }
    }
}
