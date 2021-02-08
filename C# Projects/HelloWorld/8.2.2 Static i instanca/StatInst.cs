using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._2_Static_i_instanca
{
    class StatInst
    {
        public static string ProstIliSlozen(int broj)
        {
            string odgovor = "";
            bool prostDa = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    prostDa = false;
                    break;
                }
            }
            if (prostDa)
            {
                odgovor = "prost";
            }
            else
            {
                odgovor = "složen";
            }
            return odgovor;
        }

        public string SavrseniBroj(int savrsenBroj)
        {
            int brojacDjeljitelja = 0;
            for (int j = 0; j < 10000; j++)
            {
                brojacDjeljitelja = 0;
                for (int i = 1; i < savrsenBroj; i++)
                {
                    if (savrsenBroj % i == 0)
                    {
                        brojacDjeljitelja += i;
                    }
                }
            }
            if (savrsenBroj == brojacDjeljitelja)
            {
                return "je savršen";
            }
            else
            {
                return "nije savršen";
            }
        }
    }
}
