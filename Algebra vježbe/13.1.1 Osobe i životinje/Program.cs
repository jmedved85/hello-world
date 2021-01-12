using System;
using System.Collections;
using System.Collections.Generic;

namespace _13._1._1_Osobe_i_životinje
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.Ime = "Pero";
            Osoba osoba2 = osoba1;
            osoba2.Ime = "Ana";
            // Objekti se prosljeđuju po referenci, pa se ispisuje "Ana" u sljedećem kodu
            Console.WriteLine(osoba1.Ime);

            // Ispitajno dijele li naši objekti istu referencu (adresu)
            Console.WriteLine(object.ReferenceEquals(osoba1,osoba2)); // TRUE

            // Preko novoimplementirane metode CLONE
            osoba1.Ime = "Pero";
            Osoba osoba3 = (Osoba)osoba1.Clone();
            osoba3.Ime = "Ana";
            Console.WriteLine(osoba1.Ime); // Sada je objekt x ostao netaknut
            // naši objekti x i z NE dijele istu referencu (adresu) 
            Console.WriteLine(object.ReferenceEquals(osoba1, osoba3)); // FALSE

            // Koristimo novo svojstvo Partner
            osoba1.Partner = osoba3;
            Console.WriteLine(osoba1.Ime + ", Partner:" + osoba1.Partner.Ime);
            osoba3.Partner = osoba1;
            Console.WriteLine(osoba3.Ime + ", Partner:" + osoba3.Partner.Ime);
            // objekti osoba3 i osoba 1.Partner dijele istu referencu 
            Console.WriteLine(object.ReferenceEquals(osoba3, osoba1.Partner)); // TRUE

            // Koristeći interface možemo pristupiti skupini više različitih
            // objekata ako svi oni imaju mplementiranu određenu metodu
            IDisposable dis = osoba1;
            dis.Dispose();

            // Primjer korištenja mog vlastitof interfacea
            Osoba osoba = new Osoba();
            osoba.Ime = "Pero";
            osoba.Prezime = "Perić";
            Zivotinja zivotinja = new Zivotinja();
            zivotinja.NarodniNaziv = "Divlja svinja";
            zivotinja.LatinskiNaziv = "Sus scrofa";
            ArrayList lista = new ArrayList();
            lista.Add(osoba);
            lista.Add(zivotinja);
            foreach (IMojInterface element in lista)
            {
                IspisiPunoIme(element);
            }
            Console.ReadKey();
        }

        private static void IspisiPunoIme(IMojInterface objekt)
        {
            Console.WriteLine(objekt.PunoIme());
        }
    }
}
