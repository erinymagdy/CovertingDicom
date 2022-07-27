using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Prefix
    {
        public int PrefixIncId { get; set; }
        public string? PrefixName { get; set; }
        public int? CustomerId { get; set; }
    }
}
