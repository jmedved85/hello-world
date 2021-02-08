using System;

namespace HelloWorldAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Sorry you are underage");
            }
            else if (userAge < 21)
            {
                Console.WriteLine("You need parental consent");
            }
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event!");
            }                
            
            
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);

            Console.Write("Enter your grade: ");
            string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A":
                case "A+": 
                    Console.WriteLine("Distinction");
                    break;
                case "B":
                    Console.WriteLine("B Grade");
                    break;
                case "C":
                    Console.WriteLine("C Grade");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

        }
    }
}
