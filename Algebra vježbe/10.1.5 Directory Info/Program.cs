using System;
using System.IO;

namespace _10._1._5_Directory_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            //string putanja = "";
            //do
            //{
            //    Console.WriteLine("Unesite putanju:");
            //    putanja = Console.ReadLine();
            //    string[] dirs = Directory.GetDirectories(putanja);
            //    if (Directory.Exists(putanja))
            //    {
            //        string [] sDirs = Directory.GetDirectories(putanja);
            //        foreach (var item in sDirs)
            //        {
            //            try
            //            {
            //                Console.WriteLine("Directory {0}, {1}, {2}", Path.GetFileName(item)
            //                    , Directory.GetFiles(item).GetLength(0) 
            //                    , Directory.GetDirectories(putanja).Length);
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine(e.Message);
            //            }
            //        }
            //    }
            //while (putanja != "") ;

           
            Console.WriteLine("Unesite putanju:");
            string putanja = Console.ReadLine();
            //string[] files = Directory.GetFiles(putanja);
            string[] dirs = Directory.GetDirectories(putanja);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Direktoriji:");
            Console.ResetColor();
            //int brojacDir = 0;
            foreach (string item in dirs)
            {
                try
                {
                    Console.WriteLine("{0}, {1}, {2}", Path.GetFileName(item), Directory.GetFiles(item).GetLength(0),
                                Directory.GetDirectories(putanja).Length);
                    //brojacDir++;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message); ;
                }
            }
            //Console.WriteLine($"Sadrži {brojacDir} direktorija");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Datoteke:");
            //Console.ResetColor();
            //foreach (var item in files)
            //{
            //    Console.WriteLine(Path.GetFileName(item));
            //}
        
        }
    }
}
