using System;

namespace _7._2._5_Udaljenost
{
    /* Funkcija koja računa udaljenost između dvije točke: P1(x1, y1) i
     * P2 (x2, y2) */
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite koordinate prve točke P1 (x1, y1):");
            Console.Write("x1 = ");  float x1 = float.Parse(Console.ReadLine()); 
            Console.Write("y1 = "); float y1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Unesite koordinate druge točke P2 (x2, y2):");
            Console.Write("x2 = "); float x2 = float.Parse(Console.ReadLine()); 
            Console.Write("y2 = "); float y2 = float.Parse(Console.ReadLine()); 

            Console.Write("Udaljenost između P1({0}, {1}) i P2({2}, {3}) jest: {4} cm.", x1, y1, x2, y2, Math.Round((float)Udaljenost(x1, y1, x2, y2),2));
        }

        private static object Udaljenost(float x1, float y1, float x2, float y2)
        {
            float d = (float)Math.Sqrt((float)((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
            return d;
        }
    }
}
