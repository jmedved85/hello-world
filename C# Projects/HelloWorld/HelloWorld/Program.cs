using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    //A Simple Program to display the words Hello World

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World");
            char[] message = { 'H', 'e', 'l', 'l', 'o' };
            foreach (char i in message)
            {
                Write(i);
            }

            int choice = 0;
            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Console.Write("Please enter the index of the array: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Index should be from 0 to 5.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: you did not enter an integer.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}