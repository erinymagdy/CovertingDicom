using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathPciStent
    {
        public int StentPciInc { get; set; }
        public int? StentCathDet { get; set; }
        public int? StentPciDet { get; set; }
        public string? StentType { get; set; }
        public string? StentManufacturer { get; set; }
        public double? StentLength { get; set; }
        public double? StentDiameter { get; set; }
        public byte? StentInflationPressure { get; set; }

        public virtual CathPci? StentPciDetNavigation { get; set; }
    }
}
