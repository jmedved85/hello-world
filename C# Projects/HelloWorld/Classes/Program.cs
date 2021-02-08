using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            House[] StoredHouse = new House[] {
            new House { Address = "1234 Allison St.", Size = 1500, Price = 200000 },
            new House { Address = "4567 Mark St.", Size = 3500, Price = 450000 },
            new House { Address = "891011 Karen St.", Size = 2500, Price = 270000 },
            new House { Address = "2 Antuna Vramca St.", Size = 1900, Price = 300000 },
            };

            Console.WriteLine("Press Enter to see all available house inventory.");
            Console.ReadLine();
            House.DisplayHouse(StoredHouse); // Pozivanje metode iz odvojene klase "House", proslijeđuje se jedan argument
        }
    }
}