using System;

namespace Primjer_11._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // instancirana dva datuma
            DateTime datum1 = new DateTime(2009, 1, 1, 10, 0, 0); 
            DateTime datum2 = new DateTime(2010, 1, 1, 12, 0, 0);
            // varijabla interval tipa TimeSpan kojoj je vrijednost jednaka razlici datuma datum 2 i datum1
            TimeSpan interval = datum2 - datum1;
            // ispis
            Console.WriteLine(interval); // bez specifikacije
            Console.WriteLine(interval.Days); // u danima
            Console.WriteLine(interval.Hours); // u satima
            Console.WriteLine(interval.Seconds); // u sekundima
            Console.WriteLine(interval.TotalHours); // u ukupnom broju sati
        }
    }
}
