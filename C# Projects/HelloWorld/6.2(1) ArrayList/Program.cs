using System;
using System.Collections;

namespace _6._2_1__ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList niz = new ArrayList();
            int broj = int.MaxValue;
            Console.WriteLine("Unesite brojeve u niz (za izlaz pritisnite '0':");
            while (broj != 0)
            {
                int.TryParse(Console.ReadLine(), out broj);
                niz.Add(broj);
            }
            Console.WriteLine("Ispis brojeva niza");
            Console.WriteLine($"Elemenata niza je: {niz.Count}");
            niz.Sort();
            foreach (int item in niz)
            {
                Console.WriteLine(item);
            }

            niz.RemoveAt(5);
            niz.Reverse();
            foreach (int item in niz)
            {
                Console.WriteLine(item);
            }
            niz.Clear();
        }
            
    }
}
