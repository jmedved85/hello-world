using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Ucenik : Osoba
    {
        // Konstruktor 1
        public Ucenik(string ime, string prezime) : base(ime, prezime)
        {

        }
        // Konstruktor 2
        public Ucenik(string ime, string prezime, int matematika): this(ime, prezime)
        {
            Matematika = matematika;
        }
        private int matematika;

        public int Matematika { get => matematika; set => matematika = value; }

        // Premošćivanje metode ToString naslijeđene iz klase Object
        public override string ToString()
        {
            return PunoIme();
        }
    }
}
