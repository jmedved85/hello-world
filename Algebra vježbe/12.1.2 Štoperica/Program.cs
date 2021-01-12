using System;

namespace _12._1._2_Štoperica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ŠTOPERICA");
            Console.WriteLine("Pritisnite neku tipku za start...");
            Console.ReadKey();
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Pritisnite neku tipku za kraj...");
            Console.ReadKey();
            DateTime d2 = DateTime.Now;
            TimeSpan ts = d2.Subtract(d1); // varijabla d2 oduzima varijablu d1
            Console.WriteLine($"Prevaljeno vrijeme je {ts.Hours}:{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds}");
        }
    }
}
