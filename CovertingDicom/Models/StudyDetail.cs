using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class StudyDetail
    {
        public int StudyDetailsId { get; set; }
        public int StudyIncIdDet { get; set; }
        public int? MsStatus { get; set; }
        public int? MsFirstReader { get; set; }
        public int? MsSecondReader { get; set; }
        public int? MsThirdReader { get; set; }
        public byte StudyPriority { get; set; }

        public virtual Study StudyIncIdDetNavigation { get; set; } = null!;
    }
}
