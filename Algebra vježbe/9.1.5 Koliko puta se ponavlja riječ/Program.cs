using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._1._5_Koliko_puta_se_ponavlja_riječ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KOLIKO PUTA SE PONAVLJA RIJEČ");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite rečenicu: ");
                string recenica = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova                              

                //List<string> rijeci = new List<string> (recenica.Split('.', '?', '!', ' ', ';', ':', ','));
                //int brojac = rijeci.Count();                                
                //Console.WriteLine($"Rečenica '{recenica}' ima {brojac} riječi.");

                // Prvo uzimamo sve riječi iz rečenice (može biti i duplikata)
                string[] arrSveRijeci = recenica.Split(' ', '.', '?', '!', ' ', ';', ':', ',');
                // List<string> SveRijeci = new List<string>(recenica.Split('.', '?', '!', ' ', ';', ':', ','));

                // Instanciramo objekt klase List u koji ćemo spremiti samo 
                // po jednu od svake riječi koja se pojavljuje
                List<string> PojedineRijeci = new List<string>();

                // Pregledavamo sve riječi iz rečenice
                for (int i = 0; i < arrSveRijeci.Length; i++)
                {
                    // "Dižemo zastavicu" za dodavanje riječi
                    bool dodaj = true;
                    // Pregledavamo i sve već dodane pojedine riječi
                    for (int j = 0; j < PojedineRijeci.Count; j++)
                    {
                        // Ako se ponovno pojavi riječ koja je već dodana
                        // "spuštamo zastavicu" za dodavanje
                        if (arrSveRijeci[i] == PojedineRijeci[j].ToString())
                        {
                            dodaj = false;
                            break;
                        }
                    }
                    // Ako je zastavica za dodavanje dignuta, dodajemo novu riječ
                    if (dodaj)
                    {
                        PojedineRijeci.Add(arrSveRijeci[i]);
                    }
                }

                // Ispis
                for (int i = 0; i < PojedineRijeci.Count; i++)
                {
                    Console.WriteLine($"Riječ {PojedineRijeci[i]} - broj ponavljanja: {BrojPonavljanja(PojedineRijeci[i].ToString(), recenica)}");
                }

                Console.Write("Želite li dalje (D/N)? ");
                dalje = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        private static int BrojPonavljanja(string rijec, string recenica)
        {
            int brojPonavljanja = 0;
            // Rečenicu gledamo slovo po slovo
            for (int i = 0; i <= recenica.Length - rijec.Length; i++)
            {
                // Na svakoj poziciji provjeravamo pojavljuje li se tražena riječ
                // Ako da, brojimo riječ više
              
                if (recenica.Substring(i, rijec.Length) == rijec)
                {
                    brojPonavljanja++;
                }
            }
            return brojPonavljanja;            
        }
    }
}
