using System;
using System.IO;
using System.Linq;

namespace _11._1._2_Prvi_direktorij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju: ");
            string putanja = Console.ReadLine();
            string[] dir = Directory.GetDirectories(putanja);

            var nadjeniDir = (
                from d in dir
                select d).FirstOrDefault();

            foreach (var item in nadjeniDir)
            {
                Console.Write(item);
            }
                
        }
    }
}
