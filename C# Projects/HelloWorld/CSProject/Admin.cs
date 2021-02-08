using System;
using System.Collections.Generic;
using System.Text;

namespace CSProject
{
    // Inherit the Staff class and override the CalculatePay() method
    class Admin : Staff
    {
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30;       

        public float Overtime { get => Overtime; private set => Overtime = value; }

        public Admin(string name) : base(name, adminHourlyRate)
        {
        }
        public override void CalculatePay()
        {
            base.CalculatePay(); // Calls the CalculatePay() method in the base (parent) class, which sets the values of BasicPay and TotalPay.            
            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay += Overtime;
            }
            else
            {
                TotalPay = BasicPay;
            }
        }
        public override string ToString()
        {
            return "\nNameOfStaff = " + NameOfStaff + "\nadminHourlyRate = " + adminHourlyRate + "\nHoursWorked = "
                + HoursWorked + "\nBasicPay = " + BasicPay + "\nOvertime = " + Overtime + "\n\nTotalPay = " + TotalPay;
        }

    }
}
