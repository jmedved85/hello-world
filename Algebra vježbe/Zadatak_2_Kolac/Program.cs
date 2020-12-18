using System;
using System.Collections;

namespace Zadatak_2_Kolac
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Kolac K1 = new Kolac();
            Console.WriteLine("Unesite ime kolača:");
            K1.Ime = Console.ReadLine();
            Console.WriteLine("Unesite sastojak:");
            K1.Sastojak = Console.ReadLine();
            Console.WriteLine("Unesite količinu:");
            K1.Kolicina = int.Parse(Console.ReadLine());

            Console.Write("Ispis: {0},{1}, {2}", K1.Ime, K1.Sastojak, K1.Kolicina);


          

        }
    }
}
