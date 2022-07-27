using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoSFeedback
    {
        public int FeedbackIncId { get; set; }
        public int? StudyIncId { get; set; }
        public byte? RtUsFeedback { get; set; }
        public string? RtUsNote { get; set; }
        public byte? RtMrFeedback { get; set; }
        public string? RtMrNote { get; set; }
        public byte? RtBiopsyFeedback { get; set; }
        public string? RtBiopsyNote { get; set; }
        public byte? RtOpFeedback { get; set; }
        public string? RtOpNote { get; set; }
        public byte? LtUsFeedback { get; set; }
        public string? LtUsNote { get; set; }
        public byte? LtMrFeedback { get; set; }
        public string? LtMrNote { get; set; }
        public byte? LtBiopsyFeedback { get; set; }
        public string? LtBiopsyNote { get; set; }
        public byte? LtOpFeedback { get; set; }
        public string? LtOpNote { get; set; }
        public int? PatCondition { get; set; }
        public int? FinalDiagnostic { get; set; }

        public virtual Study? StudyInc { get; set; }
    }
}
