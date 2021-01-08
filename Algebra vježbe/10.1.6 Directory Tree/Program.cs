using System;
using System.IO;

namespace _10._1._6_Directory_Tree
{
    class Program
    {
        // Za unesenu putanju ispisuje sve poddirektorije na toj putanji
        static void Main(string[] args)
        {
            // Glavni program samo poziva rekurziju
            Console.Write("Unesite putanju: ");
            GetFolders(Console.ReadLine());
            Console.ReadKey();            
        }

        static int b = 0;
        private static void GetFolders(string sPath)
        {
            // Prvo ispisujemo ime korijenskog direktorija, ali tako da bude sve lijepo uvučeno
            Console.WriteLine("{0}{1}", new string(' ', GetDepth(sPath) * 2), Path.GetFileName(sPath));
            b++;
            // Zatim uzimam sve poddirektorije tog korijenskog direktorija
            string[] sDirs = Directory.GetDirectories(sPath);
            // Pregledavam ih sve redom kroz petlju 
            foreach (string sD in sDirs)
            {
                // Rekurzivno pozivan istu tu funkciju
                GetFolders(sD);
            }
        }

        private static int GetDepth(string sPath)
        {
            // procedora prema broju \ broji koliko treba uvući ispis
            int a = 0;
            foreach (char c in sPath)
            {
                // Moramo ih staviti dvostruko, jer kod Charova @ ne radi
                if (c=='\\')
                {
                    a++;
                }
            }
            return a;
        }
    }
}
