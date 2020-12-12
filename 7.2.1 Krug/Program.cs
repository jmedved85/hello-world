using System;

namespace _7._2._1_Krug
{
    class Program
        /* Program koji za uneseni radijus ispisuje opseg i površinu kruga.
         * Za opseg i površinu napišite posebne funkcije */
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite radijus: ");
            float radijus = float.Parse(Console.ReadLine());
            Console.WriteLine("Opseg kruga je: {0}", Math.Round(Opseg(radijus),2));
            Console.WriteLine("Površina kruga je: {0}", Math.Round(Povrsina(radijus),2));
        }             

        private static float Opseg(float radijus)
        {
            float opseg = (float)((float)(radijus * 2) * Math.PI);
            return opseg;
        }
        private static float Povrsina(float radijus)
        {
            float povrsina = (float)((float)(radijus * radijus) * Math.PI);
            return povrsina;
        }
    }
}
