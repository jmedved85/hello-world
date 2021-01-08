using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._1._1_Imena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite imena:");
            List<string> listaImena = new List<string> ();
            
            while (true)
            {
                string unos = Console.ReadLine().ToLower();
                if (unos == "kraj")
                {
                    break;
                }
                else
                {
                    listaImena.Add(unos);
                }            
                
            }
            var trazenaImena = (
                from im in listaImena orderby im
                where im.Contains("a")
                select im).ToList();
            Console.WriteLine();
            Console.WriteLine("Tražena imena na 'a':");
            foreach (var item in trazenaImena)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
