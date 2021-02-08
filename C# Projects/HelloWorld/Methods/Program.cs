using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positive or Negative?");
            Console.Write("Enter a number: ");
            // int number = int.Parse(Console.ReadLine()); 
            int.TryParse(Console.ReadLine(), out int number);
            Console.WriteLine($"The number {number} is {PositiveOrNegative(number)}.");

            static string PositiveOrNegative(int number)
            {
                if (number > 0)
                {
                    string response = "positive";
                    return response;
                }
                else if (number == 0)
                {
                    string response = "is neither positive nor negative";
                    return response;
                }
                else
                {
                    string response = "is negative";
                    return response;
                }

                //string response = "";
                //if (number > 0)
                //{
                //    response = "positive";
                //}
                //else if (number < 0)
                //{
                //    response = "negative";
                //}
                //else
                //{
                //    response = "neither positive nor negative";
                //}
                //return result;
            }
        }
    }
}
