using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathPciBalloon
    {
        public int BalloonPciInc { get; set; }
        public int? BalloonPciDet { get; set; }
        public double? BalloonDiameter { get; set; }
        public double? BalloonLength { get; set; }
        public decimal? BalloonInflaTime { get; set; }
        public byte? BalloonInflaPressure { get; set; }
        public string? BalloonType { get; set; }

        public virtual CathPci? BalloonPciDetNavigation { get; set; }
    }
}
