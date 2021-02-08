using System;

namespace ClassDemo
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked // PascalCasing for name of property, // we want other classes to have access to this property
        {
            // setter demonstrates how we can use properties to control what values can be assigned to our private field
            get // first accessor
            {
                return hWorked; // hWorked is backing field of the property, returns the value od the private field
            }
            set // second accessor, sets the value of the private field
            {
                if (value > 0) // value is a keyword - it refers to the value that is on the right side of the statement when users use the property to set the value of the private field
                {
                    hWorked = value; // if it is, we assing the value to hWorked
                }
                else
                {
                    hWorked = 0;
                }                 
            }
        }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        public int CalculatePay()
        {
            PrintMessage(); // We can call one method inside another method
            int staffPay; // local variable
            staffPay = hWorked * hourlyRate;
            if (hWorked > 0)
            {
                return staffPay;
            }
            else
            {
                return 0;
            }
        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            if (hWorked > 0)
            {
                return hWorked * hourlyRate + bonus + allowance; 
            }
            else
            {
                return 0;
            }
        }
        public override string ToString() // ToString() method returns a string tipe, string that it returns contains INFORMATION about the Staff class
        {
            // the override keyword in the method declaration indicates that this method overrides the default method
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked; 
        }
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------");
        }
        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------------");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int pay;
            
            Staff staff1 = new Staff("Peter"); // using the first constructor
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400); // using second method
            Console.WriteLine("Pay = {0}", pay);
           
            Staff staff2 = new Staff("Jane", "Lee"); // using the second constructor
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay(); // using first method
            Console.WriteLine("Pay = {0}", pay);
            
            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Staff staff4 = new Staff("Jasmin", "Medved");
            staff4.HoursWorked = 90;
            pay = staff4.CalculatePay();
            Console.WriteLine($"Pay = {pay}");

            Staff staff5 = new Staff("Slađana", "Benkus");
            staff5.HoursWorked = 140;
            pay = staff5.CalculatePay(1200, 300);
            Console.WriteLine($"Pay = {pay}");
        }
    }
}
