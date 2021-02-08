using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._1_Proizvod
{
    class Proizvod
    {
        public string naziv = "";
        public double cijena = 0;
        public double marza = 0;
        public double porez = 0;

        public Proizvod (string naziv) // definirani konstruktor sa svojstvom
        {
            this.naziv = naziv;
        }

        public double MPC()
        {
            return cijena + marza + porez;
        }
    }
}
