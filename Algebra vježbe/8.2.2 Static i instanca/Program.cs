using System;

namespace _8._2._2_Static_i_instanca
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite broj:");
            int.TryParse(Console.ReadLine(), out int broj);
            Console.WriteLine($"Broj {broj} je {StatInst.ProstIliSlozen(broj)}");
            Console.WriteLine();
            Console.WriteLine("Unesite broj:");
            int.TryParse(Console.ReadLine(), out int savrseniBroj);
            StatInst savBr1 = new StatInst();
            Console.WriteLine($"Broj {savrseniBroj} {savBr1.SavrseniBroj(savrseniBroj)}");
        }   
    }
}
