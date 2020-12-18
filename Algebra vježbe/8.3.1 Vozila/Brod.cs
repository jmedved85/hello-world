using System;
using System.Collections.Generic;
using System.Text;

namespace _8._3._1_Vozila
{
    class Brod:Vozilo
    {
        public delegate void NaPromjenuIstisnineDelegat(object o, EventArgs e);
        public event NaPromjenuIstisnineDelegat NaPromjenuIstisnine;
        double istisnina;

        public double Istisnina
        {
            get { return istisnina; }
            set
            {
                istisnina = value;
                if (NaPromjenuIstisnine != null)
                {
                    NaPromjenuIstisnine(this, new EventArgs());
                }
            }
        }
    }
}
