using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counter App");
            Console.Write("Enter in a number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Console.Write("Do you want to count Up or Down from that number? (Options: Up or Down): ");
            string options = Console.ReadLine().ToLower();
            //while (options == "up")
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    break;
            //}
            //while (options == "down")
            //{
            //    for (int i = number; i >= 0; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    break;
            //}

            if (options == "up")
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(i);
                }               
            }
            else
            {
                for (int i = number; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
