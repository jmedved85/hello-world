using System;

namespace _7._2._10_Ukupna_cijena
{
    class Program
    {
        /* Program koji traži unos ulazne cijene i tada računa
         * ukupnu cijenu prema sljedećoj formuli
         * Ukupna cijena = Ulazna cijena + Marža + Porez + PDV */
        static void Main()
        {
            char ponovo = 'D';
            while (ponovo == 'D' || ponovo == 'd')
            {
                Console.WriteLine("------------------------");
                Console.Write("Unesite ulaznu cijenu: ");
                float ulaznaCijena = float.Parse(Console.ReadLine());
                if (ulaznaCijena <= 0 )
                {
                    Console.WriteLine("Neispravan unos!");
                    break;
                }
                Console.WriteLine("Ukupna cijena je: {0} kn", UkupnaCijena(ulaznaCijena));
                Console.WriteLine("------------------------");
                Console.Write("Želite li nastaviti (D/N)? ");
                ponovo = char.Parse(Console.ReadLine());
            }
                
        }

        private static float UkupnaCijena(float ulaznaCijena)
        {
            if (ulaznaCijena < 100)
            {
                float ukupnaCijena = (float)((float)ulaznaCijena + 5.5 + (ulaznaCijena * 0.02) + (ulaznaCijena * 0.25));
                return ukupnaCijena;
            }
            else if (ulaznaCijena >= 100 && ulaznaCijena < 250)
            {
                float ukupnaCijena = (float)((float)ulaznaCijena + 9.5 + (ulaznaCijena * 0.03) + (ulaznaCijena * 0.25));
                return ukupnaCijena;
            }
            else if (ulaznaCijena >= 250 && ulaznaCijena < 500)
            {
                float ukupnaCijena = (float)((float)ulaznaCijena + 15 + (ulaznaCijena * 0.04) + (ulaznaCijena * 0.25));
                return ukupnaCijena;
            }
            else if (ulaznaCijena >= 500 && ulaznaCijena < 1000)
            {
                float ukupnaCijena = (float)((float)ulaznaCijena + 25 + (ulaznaCijena * 0.05) + (ulaznaCijena * 0.25));
                return ukupnaCijena;
            }
            else
            {
                float ukupnaCijena = (float)((float)ulaznaCijena + 50 + (ulaznaCijena * 0.1) + (ulaznaCijena * 0.25));
                return ukupnaCijena;
            }
        }
    }
}
