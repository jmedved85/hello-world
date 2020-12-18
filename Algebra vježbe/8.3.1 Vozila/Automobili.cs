using System;
using System.Collections;
using System.Text;

namespace _8._3._1_Vozila
{
    class Automobili: CollectionBase
    {
        public int Add(Automobil automobil)
        {
            return InnerList.Add(automobil);
        }
        public void Remove(Automobil automobil)
        {
            InnerList.Remove(automobil);
        }
        public Automobil this[int index]
        {
            get
            {
                return (Automobil)InnerList[index];
            }
        }
    }
}
