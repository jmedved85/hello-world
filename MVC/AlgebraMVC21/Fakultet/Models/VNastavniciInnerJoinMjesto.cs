using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class VNastavniciInnerJoinMjesto
    {
        public int SifNastavnik { get; set; }
        public string ImeNastavnik { get; set; }
        public string PrezNastavnik { get; set; }
        public int PbrStan { get; set; }
        public int SifOrgjed { get; set; }
        public decimal Koef { get; set; }
        public int Pbr { get; set; }
        public string MjestoGdjeŽivi { get; set; }
    }
}
