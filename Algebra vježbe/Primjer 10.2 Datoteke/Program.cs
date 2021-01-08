using System;
using System.IO;

namespace Primjer_10._2_Datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava naš program: ");
            Console.WriteLine(Environment.CurrentDirectory);
            Console.Write("Postoji li file Proba.txt u izvršnoj mapi: ");

            // Path klasa
            // Sistemska klasa Environment - dobili smo putanju na kojoj se izvršava naš program
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            // File klasa
            Console.WriteLine(File.Exists(mojaPutanja));

            // Directory klasa
            if (!Directory.Exists("Proba"))
            {
                // Ako ne postoji folder Proba, kreiram ga
                Directory.CreateDirectory("Proba");
            }

            if (!File.Exists("Proba.txt"))
            {
                File.Create("Proba.txt");
            }

            Console.WriteLine();
            string curDirs = Environment.CurrentDirectory;
            string[] arrCurDirs = Directory.GetDirectories(curDirs);
            foreach (var item in arrCurDirs)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
            Console.WriteLine();
            string[] arrCurFiles = Directory.GetFiles(curDirs);
            foreach (var item in arrCurFiles)
            {
                Console.WriteLine(Path.GetFileName(item));
            }

            Console.WriteLine();
            // Ispisujem sve foldere na c-u
            Console.WriteLine("Direktoriji na C:");
            string[] sDirs = Directory.GetDirectories(@"C:\"); // specijalni znak @ omogućuje da će se znak '\' doslovno interpretirati a ne kao escape sekvenca
            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            // Ispisujem sve fileove na C-u 
            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach (var sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
        }
    }
}
