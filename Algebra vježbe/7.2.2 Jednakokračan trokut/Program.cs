using System;

namespace _7._2._2_Jednakokračan_trokut
{
    class Program

        /* Program za unesene duljine kateta u funkciji računa
         * površinu jednakokračnog trokuta i ispisuje ju na ekran. */
    {
        static void Main()
        {
            Console.WriteLine("Unesite duljinu dviju kateta:");
            Console.Write("Prva: "); float a = float.Parse(Console.ReadLine());
            Console.Write("Druga: "); float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Površina jednakokračnog trokuta je: {0} cm", Math.Round(Povrsina(a, b),2));
        }

        private static float Povrsina(float a, float b)
        {
            float povrsina = (a * b) / 2;
            return povrsina;
        }
    }
}
