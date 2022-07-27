using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class PeerReviewPeriod
    {
        public int PeriodIncId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public string? CustomerName { get; set; }
        public string? RandomPercentage { get; set; }
        public string? Modality { get; set; }
        public int? PeerReviewMemeberCount { get; set; }
        public int? MinimumNumberStudies { get; set; }
        public int? TotalNumberStudies { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public bool? PeerReviewIsActive { get; set; }
    }
}
