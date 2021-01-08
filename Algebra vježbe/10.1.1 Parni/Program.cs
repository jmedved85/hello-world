using System;
using System.Collections.Generic;
using System.IO;


namespace _10._1._1_Parni
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nizOd1Do100 = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    nizOd1Do100.Add(i);
                }

            }

            FileStream fs1 = new FileStream("Parni.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs1);
            foreach (var item in nizOd1Do100)
            {
                sw.WriteLine(item); 
            }
            sw.Flush();
            sw.Close();
            fs1.Close();

            FileStream fs2 = new FileStream("Parni.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs2);
            string procitano = sr.ReadToEnd();
            sr.Close();
            fs2.Close();

            Console.WriteLine(procitano);

        }
    }
}
