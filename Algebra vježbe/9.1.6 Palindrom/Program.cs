using System;
using System.Collections.Generic;
using System.Text;


namespace _9._1._6_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst:");
            string text = Console.ReadLine();
            text = text.Replace(" ", ""); // uklanjamo razmake
            // u novu string varijablu učitavamo zdesna na lijevo sve znakove
            string obrnuto = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                obrnuto += text[i];
            }
            // Ako je početni i obrnuti niz znakova isti, imamo palindrom
            if (text == obrnuto)
            {
                Console.WriteLine("To je PALINDROM");
            }
            else
            {
                Console.WriteLine("To NIJE palindrom");
            }
        }
    }
}
