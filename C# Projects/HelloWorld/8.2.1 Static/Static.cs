using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._1_Static
{
    class Static
    {
        private Static()
        {

        }
        public static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }
        public static double Kub (double broj)
        {
            return Math.Pow(broj, 3);
        }
        /// <summary>
        /// Metoda za izračunavanje udaljenosti točaka
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double UdaljenostTocaka (double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static int CelzijFahrenheit (int stupnjevi)
        {
            return (9 / 5) * stupnjevi + 32;
        }

    }
}
