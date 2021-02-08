using System;

namespace _1___Tekst_Naopako
{
    // Jasmin Medved
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Unesite tekst: ");
            Console.ResetColor();

            string tekst = Console.ReadLine();
            Console.WriteLine("--------------");

            char[] arr = tekst.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
