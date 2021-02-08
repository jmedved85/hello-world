using System;
using static System.Console;

namespace Activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of mood are you in? Good, Ok, or Bad?");
            string response = ReadLine();
            if (response == "Good")
            {
                Console.WriteLine("I am glad you are in a such a good mood today!");
            }
            else if (response == "Ok")
            {
                Console.WriteLine("You are OK!");
            }
            else if (response == "Bad")
            {
                Console.WriteLine("You are BAD!!!");
            }
            else
            {
                Console.WriteLine("I couldn't figure out what mood you are in!");
            }
        }

    }
}
