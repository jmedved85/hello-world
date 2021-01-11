using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1
{
    
    interface IPoint
    {
        // Potpisi svojstava:
        // Sadrži deklaracije svojstava odgovornih za postavljanje i vraćanje
        // vrijednosti polja (koordinata)
        int x
        {
            get;
            set;
        }
        int y
        {
            get;
            set;
        }
    }
}
