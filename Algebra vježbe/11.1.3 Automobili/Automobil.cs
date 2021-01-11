using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _11._1._3_Automobili
{
    class Automobil
    {
        private string marka;
        private string model;
        private int zapremina;

        //public Automobil(string marka, string model, string zapremina)
        //{
        //    this.marka = Marka;
        //    this.model = Model;
        //    this.zapremina = Zapremina;
        //}

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Zapremina { get => zapremina; set => zapremina = value; }

        public static Automobil UnosAutomobila() // metoda za unos podataka o automobilu
        {
            Automobil auto = new Automobil(); // najprije formiranje objekta kojeg ćemo vraćati van sa svim unešenim svojstvima
            Console.Write("Unesite marku automobila: ");
            auto.Marka = Console.ReadLine(); 
            Console.Write($"Unesite model automobila {auto.Marka}: ");
            auto.Model = Console.ReadLine();
            Console.Write($"Unesite zapreminu automobila {auto.Marka} {auto.Model}: ");
            auto.Zapremina = int.Parse(Console.ReadLine());
            return auto; // unešenog objekta iz metode
        }    
        

    }
}
