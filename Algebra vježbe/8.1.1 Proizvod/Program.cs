using System;

namespace _8._1._1_Proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROIZVOD");

            // Instanciranje objekta 'pr1' klase 'Proizvod'
            Proizvod pr1 = new Proizvod();

            // Unos vrijednosti polja klase 'Proizvod' u objekt 'pr1'
            Console.WriteLine("Unesite naziv proizvoda:");
            pr1.Naziv = Console.ReadLine();
            Console.WriteLine("Unesite početnu cijenu:");
            pr1.Cijena = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite maržu:");
            pr1.Marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite porez:");
            pr1.Porez = double.Parse(Console.ReadLine());

            // Ispis maloprodajne cijene 'MPC'
            Console.WriteLine("Maloprodajna cijena (MPC) proizvoda {0}: {1} kn.", pr1.Naziv, pr1.MPC());
        }
    }

    internal class Proizvod
    {
        public string Naziv = "";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;

        public double MPC()
        {
            return (double)(Cijena + Marza + Porez);
        }

    }
}
