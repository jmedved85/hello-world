using System;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main()
        {
            Console.Write("Unesite marku automobila: ");
            Automobil auto1 = new Automobil(Console.ReadLine());
            Console.Write("Unesite KS: ");
            auto1.KS = double.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu: ");
            auto1.OsnovnaCijena = double.Parse(Console.ReadLine());
            Console.WriteLine($"Iznos poreza je {auto1.IznosPoreza()}");
            Console.WriteLine($"Ukupna cijena je {auto1.UkupnaCijena()}");
        }
    }
}
