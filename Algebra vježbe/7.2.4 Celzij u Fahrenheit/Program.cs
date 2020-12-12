using System;

namespace _7._2._4_Celzij_u_Fahrenheit
{
    class Program
    {
        /* Program preračunava stupnjeve Celzijeve ljestvice u
         * stupnjeve Fahrenheitove. */
        static void Main()
        {
            Console.Write("Unesite vrijednost (C): ");
            float celzij = float.Parse(Console.ReadLine());
            Console.WriteLine("Pretvoreno u: {0} F", cuf(celzij));

        }
        private static float cuf(float celzij)
        {
            float fahrenheit = (float)((9/5)*celzij + 32);
            return fahrenheit;
        }
    }
}
