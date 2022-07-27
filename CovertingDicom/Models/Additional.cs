using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Additional
    {
        public int AddCode { get; set; }
        public float? AddPrice { get; set; }
        public string? AddName { get; set; }
        public string? AddNameStandard { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
