using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class PeerReview
    {
        public int PeerReviewIncId { get; set; }
        public int? StudyIncId { get; set; }
        public int? UserId { get; set; }
        public byte? Type { get; set; }
        public DateTime? ReviewDate { get; set; }
        public byte? Score { get; set; }
        public string? Comment { get; set; }
        public string? PeerReviewExtraScore { get; set; }
        public string? CommitteeExtraScore { get; set; }
    }
}
