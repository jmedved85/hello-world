using System;
using BusinessLayer;

namespace Primjer_8._3._1_Naljedjivanje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ucenik ucenik1 = new Ucenik("Pero", "Perić", 5);
            //Ucenici ucenici = new Ucenici();
            //ucenici.Add(ucenik1);
            //Ucenik ucenik2 = new Ucenik("Ana", "Anić");
            //ucenici.Add(ucenik2);
            //ucenici.Add(new Ucenik("Jure", "Jurić"));
            //ucenici.Add("Jasmin", "Medved", 5);
            //foreach (Ucenik ucenik in ucenici)
            //{
            //    Console.WriteLine(ucenik.ToString());
            //}

            Osoba osoba = new Osoba();
            // Na događaj osoba.NaPromjenuImena vezali smo funkciju glavnoga programa osoba_NaPromjenuImena koja
            // sadrži konkretne naredbe koje se izvršavaju kad se događaj dogodi
            osoba.NaPromjenuImena += new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena); // subscribe
            osoba.Ime = "Pero";
            osoba.NaPromjenuImena -= new Osoba.NaPromjenuImenaDelegat(osoba_NaPromjenuImena); // unsubscribe
            Console.ReadKey();

            static void osoba_NaPromjenuImena (object sender, EventArgs e)
            {
                Console.WriteLine("Osoba je promjenila podatke: {0}", ((Osoba)sender).Ime);
            }

        }
    }
}
