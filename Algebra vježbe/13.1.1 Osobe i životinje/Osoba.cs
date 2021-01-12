using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1._1_Osobe_i_životinje
{
    class Osoba:IMojInterface, ICloneable, IDisposable, IComparable
    {
        string ime;
        string prezime;
        Osoba partner;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public Osoba Partner { get => partner; set => partner = value; }

        // Implementacija interfejsa

        public object Clone() // Implementacija kloniranja
        {
            Osoba klon = new Osoba();
            klon.Ime = this.Ime;
            klon.Prezime = this.Prezime;
            return klon;
        }

        public int CompareTo(object obj)
        // Metoda CompareTo trebala bi vratiti -1 ako je objekt manji od trenutnog (this)
        // Vraća 0 ako su jednaki
        // Vraća 1 ako je objekt veći
        {
            Osoba os = (Osoba)obj;
            return this.Prezime.CompareTo(os.Prezime);
        }

        public void Dispose()
        // Treba se riješiti svih referenci koje sadrži naša klasa
        // npr. otvorene datoteke, otvorene veze s bazom
        // ili, u našem primjeru, moramo se riješiti partnera
        {
            Partner = null;
        }

        public string PunoIme()
        {
            return Ime + " " + Prezime;
        }
    }
}
