using System;

namespace _13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(2, 3); // Instanciran objekt p klase Point
            Console.Write("Koordinate točke: ");
            PrintPoint(p); // metodom PrintPoint ispisuje se na ekran koordinate točke p klase Point
            Console.ReadKey();
        }

        static void PrintPoint(IPoint p) // kao parametar navedena je varijabla p tipa IPoint
        {
            Console.WriteLine($"x={p.x}, y={p.y}";
        }
    }
}
