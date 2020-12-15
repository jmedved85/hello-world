using System;

namespace _8._1._3_Zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ZAPOSLENIK"); Console.ResetColor();
            Console.WriteLine();

            // Instanciranje objekata (konstruktora)
            Zaposlenik z1 = new Zaposlenik("Ivo", "Ivić");
            Zaposlenik z2 = new Zaposlenik("Marko", "Marković", "0808985320036");

            // Unos bodova
            Console.WriteLine("Unesite broj bodova:");
            z2.BrojBodova = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite vrijednost boda:");
            z2.VrijednostBoda = double.Parse(Console.ReadLine());

            // Ispis
            Console.WriteLine("Zaposlenik: {0} {1}, JMBG {2}", z2.Ime, z2.Prezime, z2.JMBG);
            Console.WriteLine("Neto plaća: {0} kn", z2.NetoIzracunPlace());
            Console.WriteLine("Porez: {0} kn", Math.Round(z2.Porez, 2));
            Console.WriteLine("Bruto plaća: {0} kn", z2.BrutoIzracunPlace());
            Console.WriteLine();
        }
    }
}
