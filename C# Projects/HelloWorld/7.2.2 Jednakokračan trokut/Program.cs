using System;

namespace _7._2._2_Jednakokračan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite dvije katete:");
            Console.Write("a = ");
            double.TryParse(Console.ReadLine(), out double a);
            Console.Write("b = ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine($"Površina jednakokračnog trokuta = {Povrsina(a, b)}");
        }

        private static double Povrsina(double a, double b)
        {
            return (a * b) / 2;
        }
    }
}
