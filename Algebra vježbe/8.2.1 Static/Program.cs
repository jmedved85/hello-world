using System;

namespace _8._2._1_Static
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Unesi dva broja (ZBROJ): ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, Static.Zbroj(a, b));
            Console.WriteLine();

            Console.Write("Unesi broj (KUB): ");
            double kub = double.Parse(Console.ReadLine());
            Console.WriteLine("Kub od {0}: {1}", kub, Static.Kub(kub));
            Console.WriteLine();

            Console.WriteLine("Unesi točke (x1, x2) i (y1, y2) (UDALJENOST TOČAKA): ");
            Console.Write("x1 = "); double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = "); double x2 = double.Parse(Console.ReadLine());
            Console.Write("y1 = "); double y1 = double.Parse(Console.ReadLine());
            Console.Write("y2 = "); double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljenost između ({0}, {1}) i ({2}, {3}) je: {4}", x1, x2, y1, y2, Static.UdaljenostTocaka(x1, x2, y1, y2));
            Console.WriteLine();

            Console.Write("Unesi koliko je stupnjeva (C): ");
            double celzijus = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit od {0} je: {1}", celzijus, Static.CelzijFahrenheit(celzijus));
        }

       
    }
}
