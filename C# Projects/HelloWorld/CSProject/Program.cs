﻿using System;
using System.Collections.Generic;

namespace CSProject
{
    class Program
    {
        static void Main()
        {
            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int month = 0, year = 0;

            while (year == 0)
            {
                Console.Write("\nPlease enter the year: ");
                try
                {
                    //Code to convert the input to an integer
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    //Code to handle the exeption
                    Console.WriteLine(e.Message + "Please try again." );
                }
            }
            while (month == 0)
            {
                Console.Write("\nPlease enter the month: ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month <1 || month > 12)
                    {
                        Console.WriteLine("Month must be from 1 to 12. Please try again.");
                        month = 0;
                    }
                }
                catch (Exception e)
                {
                    //Code to handle the exeption
                    Console.WriteLine(e.Message + "Please try again.");
                }
            }
            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.Write("\nEnter hours worked for {0}", myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            PaySlip ps = new PaySlip(month, year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);
            Console.Read();
        }
    }
}
