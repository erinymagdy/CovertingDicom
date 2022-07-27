using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathItem
    {
        public CathItem()
        {
            CathItemValues = new HashSet<CathItemValue>();
        }

        public int ItemIncId { get; set; }
        public byte? ItemCategory { get; set; }
        public int? ItemIndex { get; set; }
        public string? ItemFieldName { get; set; }
        public string? ItemFieldDesc { get; set; }
        public byte? ItemFieldDefaultIndex { get; set; }
        public byte? ItemFieldType { get; set; }
        public byte? ItemModule { get; set; }

        public virtual ICollection<CathItemValue> CathItemValues { get; set; }
    }
}
