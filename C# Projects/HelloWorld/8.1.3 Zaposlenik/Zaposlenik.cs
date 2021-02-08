using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._3_Zaposlenik
{
    class Zaposlenik
    {
        private string ime;
        private string prezime;
        private string jmbg;
        private double brojBodova;
        private double vrijednostBoda;
        private double porez;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public double BrojBodova { get => brojBodova; set => brojBodova = value; }
        public double VrijednostBoda { get => vrijednostBoda; set => vrijednostBoda = value; }
        public double Porez
        {
            get 
            {
                if (NetoIzracunPlace() < 3000)
                {
                    porez = 0.06;
                }
                else if (NetoIzracunPlace() > 3000 && NetoIzracunPlace() < 6000 )
                {
                    porez = 0.12;
                }
                else
                {
                    porez = 0.20;
                }
                return porez * NetoIzracunPlace(); 
            }            
        }

        public double NetoIzracunPlace()
        {
            return brojBodova * vrijednostBoda; 
        }

        public double BrutoIzracunPlace()
        {
            return NetoIzracunPlace() + Porez;
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik (string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik (string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Jmbg = jmbg;
        }
    }
}
