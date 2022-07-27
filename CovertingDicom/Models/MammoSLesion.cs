using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoSLesion
    {
        public int LesionIncId { get; set; }
        public int? ReportIncId { get; set; }
        public byte? Type { get; set; }
        public byte? Location { get; set; }
        public byte? BreastSide { get; set; }
        public byte? ImageView { get; set; }
        public float? MloX { get; set; }
        public float? MloY { get; set; }
        public float? CcX { get; set; }
        public float? CcY { get; set; }

        public virtual MammoSReport? ReportInc { get; set; }
    }
}
