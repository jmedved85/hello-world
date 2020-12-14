using System;

namespace _7._2._9_Prosjek
{
    /* Funkcija na temelju unesene prosječne ocjene riječima
     * ispisuje poruku o uspjehu (npr. za unesenu prosječnu
     * ocjenu 3,4 program ispisuje "Prosjek je dobar." */
    class Program
    {
        static void Main()
        {
            char ponovo = 'D';
            while (ponovo == 'D' || ponovo == 'd')
            {
                Console.Write("Unesite prosječnu ocjenu: ");
                float ocjena = float.Parse(Console.ReadLine());
                if (ocjena < 1 || ocjena > 5)
                {
                    Console.WriteLine("Neispravan unos!");
                    break;
                }
                Console.WriteLine("Prosjek je {0}.", Funkcija(ocjena));
                Console.WriteLine("Želite li nastaviti (D/N)?");
                ponovo = char.Parse(Console.ReadLine());
            }         
            
        }

        private static string Funkcija(float ocjena)
        {
            if (ocjena < 2)
            {
                return "nedovoljan";
            }
            else if (ocjena >= 2 && ocjena < 2.50)
            {
                return "dovoljan";
            }
            else if (ocjena >= 2.50 && ocjena < 3.50)
            {
                return "dobar";
            }
            else if (ocjena >= 3.50 && ocjena < 4.50)
            {
                return "vrlo dobar";
            }
            else
            {
                return "odličan";
            }
        }
    }
}
