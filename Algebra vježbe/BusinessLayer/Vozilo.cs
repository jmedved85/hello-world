using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class Vozilo
    {
        string naziv;
        string boja;
        int ks;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Boja { get => boja; set => boja = value; }
        public int KS { get => ks; set => ks = value; }

        public double KStoKW()
        {
            return ks * 0.736;
        }
    }
}
