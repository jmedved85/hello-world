using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._2_Static_i_instanca
{
    class Klasa
    {
        public static bool ProstSlozen (int broj)
        {
            bool odgovor = true;
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    odgovor = false;
                    break;
                }
            }
            return odgovor;
        }

        public bool Savrsen(int broj)
        {
            int zbrojDjelitelja = 0;
            for (int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    zbrojDjelitelja += i;
                }
            }
            if (broj == zbrojDjelitelja)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
