using System;

namespace Primjer_9._Stringovi
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo sa stringovima.";
            Console.WriteLine(recenica.ToLower());
            Console.WriteLine(recenica.ToUpper());

            Console.WriteLine(recenica.Substring(2,7)); //nas rad, lenght broji se od prvoga -> od 'n'
            Console.WriteLine(recenica.Substring(17,6)); // tringo
            Console.WriteLine(recenica.Substring(0, 5)); // danas

            Console.WriteLine(recenica.Replace("Danas", "Sutra"));
            Console.WriteLine(recenica.Replace("a", "e"));
            Console.WriteLine(recenica.Replace("radimo sa", "arbeiten mit"));
            Console.WriteLine(Reverse(recenica.Replace("radimo sa", "arbeiten mit")));

            string[] rijeci = recenica.Split(' ');
            for (int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }
            

            Console.WriteLine(recenica.Length);

            Console.WriteLine(recenica[7]);

            Console.WriteLine(Reverse(recenica));

            static string Reverse(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}
