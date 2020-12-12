using System;

namespace _7._1._1._Zbroj
{
    class Program
    {
        // Program traži unos dva broja i ispisuje njihov zbroj
        static void Main()
        {
            Console.WriteLine("Unesite dva broja:");
            int broj1 = 0;
            int broj2 = 0;
            broj1 = int.Parse(Console.ReadLine());
            broj2 = int.Parse(Console.ReadLine());
            Zbroj(broj1, broj2);
        }

        private static void Zbroj(int broj1, int broj2)
        {
            Console.WriteLine("{0}+{1}={2}", broj1, broj2, (broj1 + broj2));
        }
    }
}
