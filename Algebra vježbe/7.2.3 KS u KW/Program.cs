using System;

namespace _7._2._3_KS_u_KW
{
    class Program
    {
        // Program pretvara KS u KW (1 KS = 0,736 KW)
        static void Main()
        {
            Console.Write("Unesite vrijednost (KS): ");
            float ks = float.Parse(Console.ReadLine());
            Console.WriteLine("Pretvoreno u: {0} KW", ksukw(ks));

        }
        private static float ksukw(float ks)
        {
            float kw = (float)((float)ks * 0.736);
            return kw;
        }
    }
}
