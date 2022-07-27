using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Md
    {
        public int Mdid { get; set; }
        public string Md0 { get; set; } = null!;
        public string? Md1 { get; set; }
        public string? Md2 { get; set; }
        public string? Md3 { get; set; }
        public string? Md4 { get; set; }
        public string? Md5 { get; set; }
    }
}
