using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1._1_Osobe_i_životinje
{
    class Zivotinja : IMojInterface, IComparable
    {
        string narodniNaziv;
        string latinskiNaziv;

        public string NarodniNaziv { get => narodniNaziv; set => narodniNaziv = value; }
        public string LatinskiNaziv { get => latinskiNaziv; set => latinskiNaziv = value; }

        // Implementacija interfejsa
        public int CompareTo(object obj)
        {
            return this.LatinskiNaziv.CompareTo(((Zivotinja)obj).LatinskiNaziv);
        }

        public string PunoIme()
        {
            return string.Format($"{NarodniNaziv}, {LatinskiNaziv}");
        }
    }
}
