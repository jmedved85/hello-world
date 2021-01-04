using System;

namespace Primjer_8._5._1_Dogadjaji
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba(); // Instanciranje objekta osoba klase Osoba
            // Na događaj osoba.NaPromjenuImena vežemo funkciju u glavnom programu osoba_NaPromjenuImena
            osoba.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
            osoba.Ime = "Pero";
            osoba.NaPromjenuImena -= new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena);
            Console.ReadKey();
        }
        static void osoba_NaPromjenuImena (object sender, EventArgs e) // Funkcija sadrži konkretne naredbe koje se izvršavaju kad se događaj dogodi
        {
            Console.WriteLine("Osoba je promjenila podatke: {0}", ((Osoba)sender).Ime);
        }
    }
}
