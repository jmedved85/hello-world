using System;

namespace _8._1._3_Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik zap1 = new Zaposlenik();
            Console.Write("Unesite ime 1. zaposlenika: ");
            zap1.Ime = Console.ReadLine();
            Console.Write("Unesite prezime 1. zaposlenika: ");
            zap1.Prezime = Console.ReadLine();
            Console.Write("Unesite JMBG 1. zaposlenika: ");
            zap1.Jmbg = Console.ReadLine();
            Console.Write("Unesite broj bodova: ");
            zap1.BrojBodova = int.Parse(Console.ReadLine());
            Console.Write("Unesite vrijednost boda: ");
            zap1.VrijednostBoda = double.Parse(Console.ReadLine());

            Console.WriteLine($"Neto plaća zaposlenika {zap1.Ime} {zap1.Prezime} je: {zap1.NetoIzracunPlace()}");
            Console.WriteLine($"Bruto plaća zaposlenika {zap1.Ime} {zap1.Prezime} je: {zap1.BrutoIzracunPlace()}");

        }
    }
}
