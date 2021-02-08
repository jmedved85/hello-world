using System;

namespace _8._1._1_Proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite naziv: ");
            Proizvod proizvod = new Proizvod(Console.ReadLine());
            Console.WriteLine("Unesite cijenu:");
            proizvod.cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite maržu:");
            proizvod.marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite porez:");
            proizvod.porez = double.Parse(Console.ReadLine());

            Console.WriteLine($"MPC = {proizvod.MPC()}");
        }
    }
}
