using System;
using System.IO;

namespace _10._1._4_Dir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju:");
            string putanja = Console.ReadLine();
            string[] dirs = Directory.GetDirectories(putanja);
            string[] files = Directory.GetFiles(putanja);
            //string [] dirs = Directory.GetDirectories(@"D:\Dokumenti");
            //string [] files = Directory.GetFiles(@"D:\Dokumenti");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Direktoriji:");
            Console.ResetColor();
            foreach (var item in dirs)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Datoteke:");
            Console.ResetColor();
            foreach (var item in files)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
        }
    }
}
