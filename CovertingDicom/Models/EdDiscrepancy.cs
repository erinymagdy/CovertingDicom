using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class EdDiscrepancy
    {
        public int DiscIncId { get; set; }
        public int? StudyIncId { get; set; }
        public int? UserId { get; set; }
        public string? Comment { get; set; }
        public DateTime? ReviewDate { get; set; }
        public byte? ReviewerType { get; set; }
        public string? DiscScore { get; set; }
    }
}
