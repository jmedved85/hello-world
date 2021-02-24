using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class VStudentiIspiti
    {
        public int MbrStud { get; set; }
        public string ImeStud { get; set; }
        public int? SifPred { get; set; }
        public short? Ocjena { get; set; }
    }
}
