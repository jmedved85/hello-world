using System;

namespace _8._2._2_Static_i_instanca
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("STATIC I INSTANCA");
            
            Console.WriteLine();
            Console.Write("Unesite prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (Klasa.ProstSlozen(broj))
            {
                Console.WriteLine("Broj je prost.");
            }
            else
            {
                Console.WriteLine("Broj je složen.");
            }
            Console.WriteLine();

            Klasa sb = new Klasa();
            if (sb.Savrsen(broj))
            {
                Console.WriteLine("Broj je savršen.");
            }
            else
            {
                Console.WriteLine("Broj NIJE savršen.");
            }           

        }   
    }
}
