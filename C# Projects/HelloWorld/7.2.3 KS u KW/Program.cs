using System;

namespace _7._2._3_KS_u_KW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("KS = ");
            double.TryParse(Console.ReadLine(), out double ks);
            Console.WriteLine($"KW = {KSuKW(ks)}")
        }

        private static double KSuKW(double ks)
        {
            return ks * 0.736;
        }
    }
}
