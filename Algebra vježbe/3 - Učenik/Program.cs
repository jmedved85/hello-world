using System;
using System.Collections.Generic;

namespace _3___Učenik
{
    // Jasmin Medved
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>();
            char unos = ' ';
            while (unos != 'n')
            {
                try
                {
                    Console.Write("Unesite Ime: ");
                    string ime = Console.ReadLine();
                    Console.Write("Unesite prezime: ");
                    string prezime = Console.ReadLine();
                    Console.Write("Unesite datum rođenja: ");
                    DateTime datumRodjenja = DateTime.Parse(Console.ReadLine());
                    Console.Write("Unesite prosjek ocjena: ");
                    double prosjek = double.Parse(Console.ReadLine());
                    Ucenik uc = new Ucenik(ime, prezime, datumRodjenja, prosjek);
                    uc.NaPromjenuDatumaRodjenja += new Ucenik.NaPromjenuDatumaRodjenjaDelegat(uc_NaPromjenuDatuma);
                    uc.DatumRodjenja = datumRodjenja;
                    listaUcenika.Add(uc);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Želite li još dodavati učenike? ");
                    unos = char.Parse(Console.ReadLine().ToLower());
                    Console.ResetColor();
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Popis unešenih učenika:");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var item in listaUcenika)
            {                
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            static void uc_NaPromjenuDatuma(object sender, EventArgs e, DateTime datumRodjenja)
            {
                Ucenik uc = (Ucenik)sender;
                Console.WriteLine($"Starost: {uc.Starost(datumRodjenja)} g.");
            }
            Console.ReadKey();
        }
    }
}
