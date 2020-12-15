using System;
using System.Collections;

namespace _7._2._11_Parni_i_neparni
{
    class Program
    {
        /* Program koji preko funkcije traži unos brojeva sve dok se ne 
         * unese broj 0. Iz unesenih brojeva 2. funkcija će izvući neparne brojeve, a
         * 3. funkcija će izvući parne brojeve. 4. funkcija će ispisati posebno neparne, a 
         * posebno parne brojeve. */
        static void Main(string[] args)
        {
            Console.WriteLine("PARNI I NEPARNI");
            ArrayList brojevi = UnosBrojeva();
            Console.WriteLine("Ispis brojeva: "); Ispis(brojevi);
            Console.WriteLine("Ispis neparnih brojeva: "); Ispis(Neparni(brojevi));
            Console.WriteLine("Ispis parnih brojeva: "); Ispis(Parni(brojevi));           
        }    

        private static ArrayList UnosBrojeva()
        {
            int i = 0;
            ArrayList brojevi = new ArrayList();
            while (true)
            {
                i++;
                Console.Write("Unesite {0}. broj: ", i);
                int broj = int.Parse(Console.ReadLine());
                if (broj == 0)
                {
                    break;
                }
                brojevi.Add(broj);
            }
            return brojevi;
        }

        private static void Ispis(ArrayList brojevi)
        {
            foreach (var item in brojevi)
            {
                Console.WriteLine(item);
            }
        }
        private static ArrayList Neparni(ArrayList brojevi)
        {
            ArrayList neparni = new ArrayList();
            foreach (int item in brojevi)
            {
                if (item % 2 != 0)
                {
                    neparni.Add(item);
                }
            }
            return neparni;
        }
        private static ArrayList Parni(ArrayList brojevi)
        {
            ArrayList parni = new ArrayList();
            foreach (int item in brojevi)
            {
                if (item % 2 == 0)
                {
                    parni.Add(item);
                }
            }
            return parni;
        }
    }
}
