using System;

namespace _7._2._1_Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite radijus: ");
            int.TryParse(Console.ReadLine(), out int radijus);
            Console.WriteLine($"Opseg = {Opseg(radijus)}");
            Console.WriteLine($"Površina = {Povrsina(radijus)}");

        }

        public static double Opseg(int radijus)
        {
            return 2 * radijus * Math.PI;
        }

        public static double Povrsina(int radijus)
        {
            return Math.Pow(radijus, 2) * Math.PI;
        }
    }
}
