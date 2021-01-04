using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
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
