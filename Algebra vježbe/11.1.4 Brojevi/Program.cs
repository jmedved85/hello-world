using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._1._4_Brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodne brojeve:");
            List<int> brojevi = new List<int>();

            while (true)
            {
                int unos = int.Parse(Console.ReadLine());
                if (unos == 0)
                {
                    break;
                }
                else
                {
                    brojevi.Add(unos);
                }
            }

            var parni = (
                from par in brojevi
                where par % 2 == 0
                select par).ToList();

            var neparni = (
              from nepar in brojevi
              where nepar % 2 != 0
              select nepar).ToList();

            Console.WriteLine("Parni brojevi: ");
            foreach (var item in parni)
            {
                Console.Write($"{item}, ");                
            }
            Console.WriteLine("Neparni brojevi: ");
            foreach (var item in neparni)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
