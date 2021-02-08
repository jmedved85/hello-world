using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    // Klasa Ucenici naslijeđena je iz klase System.Collectios.CollectionBase
    class Ucenici :System.Collections.CollectionBase        
    {
        // Sjenčanje metode Add naslijeđene iz CollectionBase
        public int Add(object uc)
        {
            return base.InnerList.Add(uc);
        }
        public int Add(string ime, string prezime, int matematika)
        {
            Ucenik uc = new Ucenik(ime, prezime, matematika);
            return base.InnerList.Add(uc);
        }
        // Implementacija indeksera da bismo mogli iterirati kolekciju metodom 'foreach'
        public object this[int index]
        {
            get
            {
                return (Ucenik)base.InnerList[index];
            }
        }
    }
}
