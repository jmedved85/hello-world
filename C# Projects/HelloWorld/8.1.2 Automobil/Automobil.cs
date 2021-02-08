using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1._2_Automobil
{
    class Automobil
    {
        public string MarkaAutomobila;
        public double KS;
        public double OsnovnaCijena;

        public Automobil (string marka)
        {
            MarkaAutomobila = marka;
        }

        public double IznosPoreza()
        {
            double porez = 0;
            if (KS < 50)
            {
                porez = 0.05;                
            }
            else if (KS > 50 && KS < 150)
            {
                porez = 0.10;                
            }
            else
            {
                porez = 0.15;
            }
            return OsnovnaCijena * porez;
        }

        public double UkupnaCijena()
        {
            return OsnovnaCijena + IznosPoreza();
        }

    }
}
