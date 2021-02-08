using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    // Contains information about each staff in the company. 
    // Method CalculatePay() calculates the pay of each staff.
    // Parent class from which two other classes will be derived.
    class Staff
    {
        private float hourlyRate;
        private int hWorked;        

        public float TotalPay { get => TotalPay; protected set => TotalPay = value; }
        public float BasicPay { get => BasicPay; private set => BasicPay = value; }
        public string NameOfStaff { get => NameOfStaff; private set => NameOfStaff = value; }
        public int HoursWorked
        {
            get { return hWorked; }
            set
            {
                if (HoursWorked > 0)
                {
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }

        public Staff(string name, float rate)
        {
            name = NameOfStaff;
            rate = hourlyRate;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nhourlyRate = " + hourlyRate + "\nhWorked = " 
                + hWorked + "\nBasicPay = " + BasicPay + "\n\nTotalPay = " + TotalPay;
        }
    }
}
