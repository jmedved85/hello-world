using System;

namespace _9._1._1_Znak_u_rečenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZNAK U RIJEČI");
            Console.WriteLine();
            char dalje = ' ';

            while (dalje != 'n')
            {
                Console.Write("Unesite riječ: ");
                string rijec = Console.ReadLine().ToLower(); // Unos stringa, konvertira se u mala slova

                Console.Write("Unesite znak: ");
                char znak = char.Parse(Console.ReadLine().ToLower()); // Unos char-a, konvertira se u mala slova

                char[] arr; // Deklaracija niza
                int brojac = 0; // Deklaracija integera za brojanje
                arr = rijec.ToCharArray(); // Konvertiranje unesenog stringa u char i niz
                foreach (char r in arr)
                {
                    if (znak == r)
                    {
                        brojac++; // Brojac se pobroji za 1 svaki puta kada nađe uneseni znak u riječi
                    }
                }
                Console.WriteLine($"Znak '{znak}' pojavljuje se {brojac} puta.");
                Console.WriteLine("----------------------");
                Console.Write("Želite li dalje (D/N)? ");
                dalje = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("----------------------");
                
            }
        }
    }
}
