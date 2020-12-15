using System;

namespace _8._1._2_Automobil
{
    internal class Automobil
    {
        internal string MarkaAutomobila;
        internal double KS;
        internal double OsnovnaCijena;
        double porez = 0;

        internal double IznosPoreza()
        {
            if (KS < 50)
            {
                porez = 5;
                return porez;
            }
            else if (KS > 50 && KS < 150)
            {
                porez = 10;
                return porez;
            }
            else
            {
                porez = 15;
                return porez;
            }
        }

        internal double UkupnaCijena()
        {
            return OsnovnaCijena + porez * (OsnovnaCijena/100);
        }
    }
}