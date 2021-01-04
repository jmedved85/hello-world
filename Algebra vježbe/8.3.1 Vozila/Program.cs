using System;
using System.Collections;

namespace _8._3._1_Vozila
{
    class Program
    {
        static void Main(string[] args)
        {
            // Na početku dižemo "zastavicu" za unos
            char unos = 'D';

            // Instanciramo liste
            ArrayList vozila = new ArrayList();
            Automobili automobili = new Automobili();

            // Dok je "zastavica" za unos dignuta, učitavamo vozila
            while (unos == 'D' || unos == 'd')
            {
                // Odabir tipa vozila
                Console.WriteLine("Za unos automobila odaberite 1, a za unos broda odaberite 2!");
                Console.Write("Vaš odabir: ");
                char odabir = Console.ReadKey(false).KeyChar;
                Console.WriteLine();
                if (odabir == '1')
                {
                    // Instanciramo objekt klase Automobil
                    Automobil automobil = new Automobil();
                    // Inicijalizacija objekta automobila
                    Console.Write("Unesite naziv automobila: ");
                    automobil.Naziv = Console.ReadLine();
                    Console.Write("Unesite boju automobila: ");
                    automobil.Boja = Console.ReadLine();
                    Console.Write("Unesite KS automobila: ");
                    automobil.KS = int.Parse(Console.ReadLine());
                    Console.Write("Unesite ccm automobila: ");
                    automobil.Ccm = double.Parse(Console.ReadLine());
                    // Novi objekt klase Automobili dodajemo u obje liste
                    vozila.Add(automobil);
                    automobili.Add(automobil);
                }
                else if (odabir == '2')
                {
                    // Instanciranje objekta klase Brod
                    Brod brod = new Brod();
                    // Delegiranje događaja
                    
                    brod.NaPromjenuIstisnine += new Brod.NaPromjenuIstisnineDelegat(NaPromjenuIstisnine);
                    Console.Write("Unesite naziv broda: ");
                    brod.Naziv = Console.ReadLine();
                    Console.Write("Unesite boju broda: ");
                    brod.Boja = Console.ReadLine();
                    Console.Write("Unesite KS broda: ");
                    brod.KS = int.Parse(Console.ReadLine());
                    Console.Write("Unesite istisninu broda: ");
                    brod.Istisnina = double.Parse(Console.ReadLine());
                    // Novi objekt klase Brod dodajemu u listu vozila
                    vozila.Add(brod);
                }
                else
                {
                    Console.WriteLine("Pogrešan odabir!");
                }
                Console.Write("Želite li unositi još vozila (D/N)?");
                unos = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }

            // Ispis liste vozila
            Console.WriteLine("Sva vozila:");
            foreach (object objekt in vozila)
            {
                // Elemente liste koji su klase Object moramo "kastati"
                Vozilo vozilo = (Vozilo)objekt;
                Console.WriteLine("Naziv: {0}, Boja: {1}, KS: {2}, KW: {3}", vozilo.Naziv, vozilo.Boja, vozilo.KS, vozilo.KStoKW());
            }

            // Ispis kolekcija automobili
            Console.WriteLine("Automobili:");
            foreach (Automobil automobil in automobili)
            {
                Console.WriteLine(automobili.ToString());
            }
            Console.ReadKey();
            brod.NaPromjenuIstisnine -= new Brod.NaPromjenuIstisnineDelegat(NaPromjenuIstisnine);
        }
        // Implementacija događaja NaPromjenuIstisnine
         static void NaPromjenuIstisnine(object o, EventArgs e)
        {
            Brod brod = (Brod)o;
            Console.WriteLine("Dogodila se promjena istisnine.");
            Console.WriteLine("Nova istisnina: {0}", brod.Istisnina);
        }
    }
}
