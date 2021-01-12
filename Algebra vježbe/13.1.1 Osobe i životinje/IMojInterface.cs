using System;
using System.Collections.Generic;
using System.Text;

namespace _13._1._1_Osobe_i_životinje
{
    // Defeniran je vlastiti interface
    public interface IMojInterface
    {
        // Nema modifikatora pristupa, nego se svi tretiraju kao PUBLIC bez navođenja 
        // (logično jer se interface mora implementirati drugdje da bi se kiskoristio)
        string PunoIme();
    }
}
