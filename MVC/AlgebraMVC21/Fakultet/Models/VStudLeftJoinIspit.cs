using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class VStudLeftJoinIspit
    {
        public int MbrStud { get; set; }
        public string ImeStud { get; set; }
        public string PrezStud { get; set; }
        public int? PbrRod { get; set; }
        public int PbrStan { get; set; }
        public DateTime? DatRodStud { get; set; }
        public string JmbgStud { get; set; }
        public int? Expr1 { get; set; }
        public int? SifPred { get; set; }
        public int? SifNastavnik { get; set; }
        public DateTime? DatIspit { get; set; }
        public short? Ocjena { get; set; }
    }
}
