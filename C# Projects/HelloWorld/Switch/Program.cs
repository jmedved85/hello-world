using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a letter and find out if it is a vowel.");
            string letter = Console.ReadLine();
            switch (letter)
            {
                case "a": 
                case "e": 
                case "o": 
                case "i": 
                case "u":
                    Console.WriteLine($"The lowercase \"{letter}\" is a vowel!");  
                    break;
                case "A":
                case "E":
                case "O":
                case "I":
                case "U":
                    Console.WriteLine($"The uppercase \"{letter}\" is a vowel!");
                    break;
                default:
                    Console.WriteLine($"The \"{letter}\" is NOT a vowel!");
                    break;                   
            }
        }
    }
}
