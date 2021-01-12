using System;

namespace _11._1._1_Rođendan
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime sadaVrijeme = DateTime.Now;            
            Console.Write("Unesite Ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            Osoba os = new Osoba(ime, prezime); // unešene varijable šeljemo u instancirani objekt klase Osoba
            //Console.Write("Unesite datum rođenja: ");
            //os.DatumRodjenja = DateTime.Parse(Console.ReadLine());
            // TimeSpan interval = sadaVrijeme - os.DatumRodjenja;            
            //Console.WriteLine($"{os.Ime} {os.Prezime} || {os.DatumRodjenja.ToLongDateString()/*ToString("dd.MM.yyyy.")*/} || godina.");
            // Unosimo spol
            Console.Write("Unesite spol (M = Muški, Ž= Ženski): ");
            string spol = Console.ReadLine().ToLower();
            if (spol == "m")
            {
                os.Spol = Spol.Muški; // enum spol
            }
            else if (spol == "ž")
            {
                os.Spol = Spol.Ženski; // enum spol
            }
            else
            {
                Console.WriteLine("Unesite 'M' ili 'Ž'");                
            }
            Console.WriteLine();
            Console.Write("Unesite datum rođenja: ");
            DateTime d = DateTime.Parse(Console.ReadLine()); // unos parsiramo u DateTime format

            // Implementacija događaja - 1
            os.Rodjendan += new Osoba.RodjendanDelegat(os_Rodjendan); // SUBSCRIBE
            // na događaj smo vezali funkciju glavnoga programa os_Rodjendan
            // Izazivanje događaja
            os.DatumRodjenja = d;
            // Bez obzira na događaj ispisujemo starost
            Console.WriteLine($"{os.Ime} {os.Prezime}");
            Console.WriteLine($"Datum rođenja: {os.DatumRodjenja.ToLongDateString()}");           
            Console.WriteLine($"Vaša starost: {os.Starost}");
            Console.WriteLine($"Vaš spol: {os.Spol}");
            // Otpuštanje objekta
            os.Rodjendan -= new Osoba.RodjendanDelegat(os_Rodjendan); // UNSUBSCRIBE

        }
        // Implementacija događaja - 2
        static void os_Rodjendan(object sender, EventArgs e)
        {
            Osoba os = (Osoba)sender;
            Console.WriteLine($"SRETAN ROĐENDAN {os.Ime}");
        }
    }
}
