using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class House
    {
        private string address;
        private double size;
        private double price;

        public string Address { get => address; set => address = value; }
        public double Size { get => size; set => size = value; }
        public double Price { get => price; set => price = value; }
        public static void DisplayHouse(House[] StoredHouse)
        {
            foreach (var item in StoredHouse)
            {
                Console.WriteLine($"Adress: {item.Address} / Size: {item.Size} / Price: {item.Price:C}");
            }
        }
    }
}
