using System;

namespace _8._2._1_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZBROJ");
            Console.WriteLine("Unesite dva broja:");
            double.TryParse(Console.ReadLine(), out double broj1);
            double.TryParse(Console.ReadLine(), out double broj2);
            Console.WriteLine($"{broj1} + {broj2} = {Static.Zbroj(broj1, broj2)}");
            
            Console.WriteLine( );
            Console.WriteLine("KUB");
            Console.Write("Unesite broj: ");
            double.TryParse(Console.ReadLine(), out double broj);
            Console.WriteLine($"Kub od {broj} = {Static.Kub(broj)}");

            Console.WriteLine();
            Console.WriteLine("UDALJENOST TOČAKA");
            Console.Write("x1 = ");
            double.TryParse(Console.ReadLine(), out double x1);
            Console.Write("x2 = ");
            double.TryParse(Console.ReadLine(), out double x2);
            Console.Write("y1 = ");
            double.TryParse(Console.ReadLine(), out double y1);
            Console.Write("y2 = ");
            double.TryParse(Console.ReadLine(), out double y2);
            Console.WriteLine($"Udaljenost između P1({x1}, {y1}) i P2({x2}, {y2}) = {Static.UdaljenostTocaka(x1, x2, y1, y2)}");

            Console.WriteLine();
            Console.WriteLine("FAHRENHEIT");
            Console.Write("Unesite koliko je stupnjeva Celzijusa: ");
            int.TryParse(Console.ReadLine(), out int stupnjevi);
            Console.WriteLine($"Fahrenheit od {stupnjevi} stupnjeva Celzijusa = {Static.CelzijFahrenheit(stupnjevi)}");
           
        }
    }
}
