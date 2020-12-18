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

        public static double Zbroj (double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        public static double Kub(double broj)
        {
            return Math.Pow(broj, 3);
        }

        public static double UdaljenostTocaka (double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
        
        public static double CelzijFahrenheit (double stupnjevi)
        {
            return stupnjevi * 1.8 + 32;
        }
    }
}
