using System;

namespace _7._2._4_Celzij_u_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celzij = ");
            double.TryParse(Console.ReadLine(), out double celzij);
            Console.WriteLine($"Fahrenheit = {Fahrenheit(celzij)}");
        }

        private static double Fahrenheit(double celzij)
        {
            return (9 / 5) * celzij + 32;
        }
    }
}
