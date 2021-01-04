using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Automobil:Vozilo
    {
        double ccm;

        public double Ccm { get => ccm; set => ccm = value; }

        public override string ToString()
        {
            return string.Format("Naziv: {0}, Boja: {1}, KS: {2}, KW: {3}.", Naziv, Boja, KS, KStoKW());
        }
    }
}
