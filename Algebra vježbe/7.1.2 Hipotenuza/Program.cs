using System;

namespace _7._1._2_Hipotenuza
{
    class Program
    /*Program traži unos duljina dviju kateta pravokutnog trokuta i zatim
     *u potprogramu ispisuje duljinu hipotenuze*/
    {
        static void Main()
        {
            Console.WriteLine("Unesite duljinu dviju kateta:");
            Console.Write("Prva: "); float a = float.Parse(Console.ReadLine());
            Console.Write("Druga: "); float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Duljina hipotenuze je: {0}", Hipotenuza(a, b));
        }

        private static float Hipotenuza(float a, float b)
        {
            float c = (float)Math.Sqrt((a * a) + (b * b));
            return c;
        }        
    }        
}
