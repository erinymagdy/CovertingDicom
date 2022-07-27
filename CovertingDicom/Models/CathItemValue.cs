using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathItemValue
    {
        public int ItemsValuesIncId { get; set; }
        public int? ItemsValuesItemDet { get; set; }
        public string? ItemsValuesItemName { get; set; }
        public byte? ItemsValuesValueName { get; set; }
        public string? ItemsValuesDesc { get; set; }

        public virtual CathItem? ItemsValuesItemDetNavigation { get; set; }
    }
}
