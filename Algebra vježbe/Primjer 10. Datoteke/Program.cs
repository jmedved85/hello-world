using System;
using System.IO;

namespace Primjer_10._Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite tekst: ");
            string upisano = Console.ReadLine();

            // Kreiranje datoteke u istom direktoriju u kojem se nalazi izvršna datoteka aplikacije
            /* Instanciranje objekta fs1 klase FileStream koji otvara stream (tok) podataka
             * prema datoteci (otvara datoteku) u modu FileMode.Create */
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);
            
            // Zapisivanje u datoteku
            // Instanciranje objekta sw klase StreamWriter koji služi za zapisivanje podataka u navedeni objekt fs1
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine(upisano); // zapisivanje teksta u objekt fs1 metodom WriteLine
            sw.Flush(); // zapisivanje teksta u datoteku
            sw.Close(); // zatvaranje streawritera
            fs1.Close(); // zatvaranje filestreama

            // Čitanje datoteke
            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2);
            string procitano = sr.ReadToEnd(); // čita cijelu datoteku 'Proba.txt' i njezin sadržaj vraća kao string vrijednost
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano); // ispis varijable 'procitano'

            //FileStream fs3 = new FileStream("Proba.txt", FileMode.Append);
            //StreamReader sr2 = new StreamReader(fs2);
            //string procitano2 = sr.ReadToEnd(); // čita cijelu datoteku 'Proba.txt' i njezin sadržaj vraća kao string vrijednost
            //sr.Close();
            //fs2.Close();
        } 
    }
}
