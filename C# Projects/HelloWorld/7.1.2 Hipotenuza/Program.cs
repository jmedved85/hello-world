using System;

namespace _7._1._2_Hipotenuza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dvije katete:");
            Console.Write("a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write("b = ");
            int.TryParse(Console.ReadLine(), out int b);
            Ispis(a, b);

            static void Ispis(int a, int b)
            {
                Console.WriteLine($"Duljina hipotenuze = {Math.Sqrt(Math.Pow(a, 2) + Math.Pow (b, 2))}");
            }
        }
    }
}
