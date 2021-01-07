using System;

namespace _9._1._2_Riječ_u_rečenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RIJEČ U REČENICI");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite rečenicu: ");
                string recenica = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova

                Console.Write("Unesite riječ: ");
                string rijec = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova

                int brojac = 0; // Deklaracija integera za brojanje

                // Rečenicu pregledavamo slovo po slovo
                for (int i = 0; i <= recenica.Length - rijec.Length; i++)
                {
                    // Na svakoj poziciji provjeravamo pojavljuje li se tražena riječ
                    // Ako da, brojimo riječ više
                    if (recenica.Substring(i, rijec.Length)==rijec)
                    {
                        brojac++;
                    }
                }

                Console.WriteLine($"Riječ '{rijec}' pojavljuje se {brojac} puta.");
                
                Console.Write("Želite li dalje (D/N)? ");
                dalje = Console.ReadKey().KeyChar;
                Console.WriteLine();                      
                
            }
        }
    }
}
