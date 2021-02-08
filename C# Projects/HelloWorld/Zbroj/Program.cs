using System;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dva broja:");
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out int b);
            Ispis(a, b);

            static void Ispis (int a, int b)
            {
                Console.WriteLine($"{a} + {b} = {a+b}");
            }
        }
    }
}
