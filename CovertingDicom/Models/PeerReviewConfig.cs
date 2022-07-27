using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class PeerReviewConfig
    {
        public int RandomId { get; set; }
        public string? CustomerName { get; set; }
        public int? PeriodId { get; set; }
        public string? RandomPercentage { get; set; }
        public string? Modality { get; set; }
        public int? PeerReviewMemeberCount { get; set; }
        public bool? IsActive { get; set; }
        public int? MinimumNumberStudies { get; set; }
        public string? User { get; set; }
    }
}
