using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoSReport
    {
        public MammoSReport()
        {
            MammoSLesions = new HashSet<MammoSLesion>();
        }

        public int ReportIncId { get; set; }
        public int? StudyIncId { get; set; }
        public byte? ReportOrder { get; set; }
        public DateTime? ReportDate { get; set; }
        public byte? Evaluation { get; set; }
        public byte? Density { get; set; }
        public string? TechnicalNote { get; set; }
        public byte? RtBirad { get; set; }
        public string? RtRecomm { get; set; }
        public byte? RtExpect { get; set; }
        public byte? LtBirad { get; set; }
        public string? LtRecomm { get; set; }
        public byte? LtExpect { get; set; }

        public virtual Study? StudyInc { get; set; }
        public virtual ICollection<MammoSLesion> MammoSLesions { get; set; }
    }
}
