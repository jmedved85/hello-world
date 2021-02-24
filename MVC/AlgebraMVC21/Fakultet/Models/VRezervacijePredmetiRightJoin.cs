using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class VRezervacijePredmetiRightJoin
    {
        public short? Sat { get; set; }
        public int SifPred { get; set; }
        public string KratPred { get; set; }
        public string NazPred { get; set; }
        public int? SifOrgjed { get; set; }
        public int? UpisanoStud { get; set; }
        public int? BrojSatiTjedno { get; set; }
    }
}
