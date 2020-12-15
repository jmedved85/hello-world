using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._3_Zaposlenik
{
    class Zaposlenik
    {
        string ime;
        string prezime;
        string jmbg;
        double brojBodova;
        double vrijednostBoda;
        double porez;      

       
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string JMBG { get => jmbg; set => jmbg = value; }
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }
                else
                {
                    Exception ex = new Exception("Možete unijeti samo pozitivnu brojčanu vrijednost!");
                    throw ex;
                }
            }
        }
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set
            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Možete unijeti samo pozitivnu brojčanu vrijednost!");
                    throw ex;
                }
            }
        }

        public double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }

        public double Porez
        {
            get
            {
                double postotak;
                if (NetoIzracunPlace() < 3000)
                {
                    postotak = 0.06;
                }
                else if (NetoIzracunPlace() > 3000 && NetoIzracunPlace() < 6000)
                {
                    postotak = 0.12;
                }
                else
                {
                    postotak = 0.20;
                }
                return NetoIzracunPlace() * postotak;
            }
        }

        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }

        public Zaposlenik()
        {

        }

        public Zaposlenik(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string jmbg)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.JMBG = jmbg;
        }

    }
}
