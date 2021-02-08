using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bill Calculator");
            Console.WriteLine("---------------");

            Console.Write("How much was the entree? ");
            double.TryParse(Console.ReadLine(), out double entree);
            Console.Write("How much was the drink? ");
            double.TryParse(Console.ReadLine(), out double drink);
            Console.Write("How much was the desert? ");
            double.TryParse(Console.ReadLine(), out double dessert);

            Console.WriteLine($"The total for all 3 items is: {(entree + drink + dessert):C}");
        }
    }
}
