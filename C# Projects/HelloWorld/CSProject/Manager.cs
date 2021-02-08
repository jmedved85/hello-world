using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    // Inherit the Staff class and override the CalculatePay() method
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        
        public int Allowance { get => Allowance; private set => Allowance = value; }

        public Manager( string name) : base(name, managerHourlyRate)
        {
        }
        public override void CalculatePay()
        {
            base.CalculatePay(); // Calls the CalculatePay() method in the base (parent) class, which sets the values of BasicPay and TotalPay.
            Allowance = 1000;
            if (HoursWorked > 160)
            {
                TotalPay += Allowance;
            }
            else
            {
                TotalPay = BasicPay;
            }
        }
        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nmanagerHourlyRate = " + managerHourlyRate + "\nHoursWorked = " 
                + HoursWorked + "\nBasicPay = " + BasicPay + "\nAllowance = " + Allowance + "\n\nTotalPay = " + TotalPay;
        }

    }
}
