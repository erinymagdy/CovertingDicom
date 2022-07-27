using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Additionals = new HashSet<Additional>();
        }

        public int CustId { get; set; }
        public string? Ccu { get; set; }

        public virtual ICollection<Additional> Additionals { get; set; }
    }
}
