using System;

namespace _7._2._9_Prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "D";
            while (izbor == "D" || izbor == "d")
            {
                Console.Write("Unesite prosječnu ocjenu: ");
                double.TryParse(Console.ReadLine(), out double ocjena);
                Console.WriteLine("------------------------");
                Console.WriteLine($"Prosjek je {Prosjek(ocjena)}!");
                Console.WriteLine("Želite li ponovno (D/N)?");
                izbor = Console.ReadLine();
            }
        }

        private static string Prosjek(double ocjena)
        {
            string prosjek = "";
            if (ocjena < 1.5)
            {
                prosjek = "nedovoljan";
            }
            else if (ocjena >= 1.5 && ocjena < 2.5)
            {
                prosjek = "dovoljan";
            }
            else if (ocjena >= 2.5 && ocjena < 3.5)
            {
                prosjek = "dobar";
            }
            else if (ocjena >= 3.5 && ocjena < 4.5)
            {
                prosjek = "vrlo dobar";
            }
            else 
            {
                prosjek = "odličan";
            }
            return prosjek;
        }
    }
}
