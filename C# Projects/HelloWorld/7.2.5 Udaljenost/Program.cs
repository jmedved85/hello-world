using System;

namespace _7._2._5_Udaljenost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double.TryParse(Console.ReadLine(), out double x1);
            Console.Write("x2 = ");
            double.TryParse(Console.ReadLine(), out double x2);
            Console.Write("y1 = ");
            double.TryParse(Console.ReadLine(), out double y1);
            Console.Write("y2 = ");
            double.TryParse(Console.ReadLine(), out double y2);

            Console.WriteLine($"Udaljenost između P1({x1}, {y1}) i P2({x2}, {y2}) = {Udaljenost(x1,x2,y1,y2)}");
        }

        private static double Udaljenost(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

    }
}
