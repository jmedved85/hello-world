using System;
using System.Collections.Generic;

#nullable disable

namespace Fakultet.Models
{
    public partial class VProlaznostIspitum
    {
        public string ImeStud { get; set; }
        public string PrezStud { get; set; }
        public short Ocjena { get; set; }
        public string ImeNastavnik { get; set; }
        public string PrezNastavnik { get; set; }
    }
}
