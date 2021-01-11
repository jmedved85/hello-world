using System;

namespace Primjer_12._1._1_Uspoređivanje_datuma
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2015, 1, 1);
            DateTime datum2 = new DateTime(2021, 1, 1);
            DateTime datum3 = new DateTime();
            datum3 = DateTime.Now;
            if (datum1 < datum2)
            {
                Console.WriteLine("1.1.2015. je manji od 1.1.2021.");
            }
            else
            {
                Console.WriteLine("1.1.2015. je veći od 1.1.2021.");
            }
            Console.WriteLine(datum3);
            Console.WriteLine("Unesi datum");
            DateTime datum4 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(datum4);
        }
    }
}
