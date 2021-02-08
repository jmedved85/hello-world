using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = new string[12] {"January", "February", "March", "April", "May", "June", "July"
                , "August", "September", "October", "November", "December"};
            Console.WriteLine("Enter a month (1-12) to display the month name or type Display All:");
            string enter = Console.ReadLine().ToLower();
            if (enter == "display all")
            {
                foreach (var item in months)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                int.TryParse(enter, out int numMonth);
                if (numMonth >= 1 && numMonth <= 12)
                {
                    Console.WriteLine($"{numMonth} is {months[numMonth - 1]}");
                }
                else
                {
                    Console.WriteLine("Not a valid input!");
                }
            }
            //switch (enter)
            //{
            //    case "1": Console.WriteLine(months[0]);
            //        break;
            //    case "2":
            //        Console.WriteLine(months[1]);
            //        break;
            //    case "3":
            //        Console.WriteLine(months[2]);
            //        break;
            //    case "4":
            //        Console.WriteLine(months[3]);
            //        break;
            //    case "5":
            //        Console.WriteLine(months[4]);
            //        break;
            //    case "6":
            //        Console.WriteLine(months[5]);
            //        break;
            //    case "7":
            //        Console.WriteLine(months[6]);
            //        break;
            //    case "8":
            //        Console.WriteLine(months[7]);
            //        break;
            //    case "9":
            //        Console.WriteLine(months[8]);
            //        break;
            //    case "10":
            //        Console.WriteLine(months[9]);
            //        break;
            //    case "11":
            //        Console.WriteLine(months[10]);
            //        break;
            //    case "12":
            //        Console.WriteLine(months[11]);
            //        break;
            //    case "display all":
            //        foreach (var item in months)
            //        {
            //            Console.WriteLine(item);
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Not a valid input!");
            //        break;
        }
        
    }
}
