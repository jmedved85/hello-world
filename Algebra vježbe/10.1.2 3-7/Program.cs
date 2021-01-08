using System;
using System.Collections.Generic;
using System.IO;

namespace _10._1._2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nizOd0Do100 = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    nizOd0Do100.Add(i);
                }

            }

            FileStream fs1 = new FileStream("3or7uNoviRed.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);
            foreach (var item in nizOd0Do100)
            {
                sw1.WriteLine(item);
            }
            sw1.Flush();
            sw1.Close();
            fs1.Close();

            FileStream fs2 = new FileStream("3or7SaZarezima.txt", FileMode.Create);
            StreamWriter sw2 = new StreamWriter(fs2);
            foreach (var item in nizOd0Do100)
            {
                sw2.Write($"{item}, ");
            }
            sw2.Flush();
            sw2.Close();
            fs2.Close();

            FileStream fsRead1 = new FileStream("3or7uNoviRed.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fsRead1);
            string procitanoNoviRed = sr1.ReadToEnd();
            sr1.Close();
            fsRead1.Close();

            Console.WriteLine("3or7uNoviRed.txt");
            Console.WriteLine(procitanoNoviRed);

            FileStream fsRead2 = new FileStream("3or7SaZarezima.txt", FileMode.Open);
            StreamReader sr2 = new StreamReader(fsRead2);
            string procitanoSaZarezima = sr2.ReadToEnd();
            sr2.Close();
            fsRead2.Close();

            Console.WriteLine("3or7SaZarezima.txt");
            Console.WriteLine(procitanoSaZarezima);

        }
    }
}
