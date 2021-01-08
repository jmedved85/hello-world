using System;
using System.Collections.Generic;
using System.IO;

namespace _10._1._3_Par_Nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodne brojeve (sve dok ne upišete '0')");
            int broj = int.MaxValue;
            List<int> parni = new List<int>();
            List<int> neparni = new List<int>();
            while (broj !=0)
            {
                broj = int.Parse(Console.ReadLine());
                if (broj%2==0)
                {
                    parni.Add(broj);
                }
                else
                {
                    neparni.Add(broj);
                }
            }

            FileStream fsParni = new FileStream("parni.txt", FileMode.Append);
            StreamWriter swParni = new StreamWriter(fsParni);
            foreach (var item in parni)
            {
                swParni.WriteLine(item); 
            }
            swParni.Flush();
            swParni.Close();
            fsParni.Close();

            FileStream fsNeparni = new FileStream("neparni.txt", FileMode.Append);
            StreamWriter swNeparni = new StreamWriter(fsNeparni);
            foreach (var item in neparni)
            {
                swNeparni.WriteLine(item);
            }
            swNeparni.Flush();
            swNeparni.Close();
            fsNeparni.Close();

            FileStream fsReadParni = new FileStream("parni.txt", FileMode.Open);
            FileStream fsReadNeparni = new FileStream("neparni.txt", FileMode.Open);
            StreamReader srParni = new StreamReader(fsReadParni);
            string procParni = srParni.ReadToEnd();
            StreamReader srNeparni = new StreamReader(fsReadNeparni);
            string procNeparni = srNeparni.ReadToEnd();
            Console.WriteLine();
            Console.WriteLine("parni.txt");
            Console.WriteLine(procParni);
            Console.WriteLine();
            Console.WriteLine("neparni.txt");
            Console.WriteLine(procNeparni);
            Console.WriteLine();
            srParni.Close();
            srNeparni.Close();
            fsReadParni.Close();
            fsReadNeparni.Close();           

        }
    }
}
