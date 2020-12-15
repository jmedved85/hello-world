using System;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("AUTOMOBIL"); Console.ResetColor();
            Console.WriteLine();

            // Instanciranje objekta klase 'Automobil'
            Automobil aut1 = new Automobil();

            // Unos polja klase 'Automobil'
            Console.WriteLine("Unesite marku:");
            aut1.MarkaAutomobila = Console.ReadLine();
            Console.WriteLine("Unesite KS:");
            aut1.KS = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite osnovnu cijenu:");
            aut1.OsnovnaCijena = double.Parse(Console.ReadLine());

            // Ispis iznosa poreza i ukupne cijene
            Console.WriteLine("Automobil {0} oporezovan je s {1}% i njegova ukupna cijena je: {2} kn."
                , aut1.MarkaAutomobila, aut1.IznosPoreza(), aut1.UkupnaCijena());         
        }
    }
}
