using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class SharedStudy
    {
        public int SharedStudiesIncId { get; set; }
        public string UrlUid { get; set; } = null!;
        public int CreatorId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public int StudyIncId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Reason { get; set; }
        public string? Message { get; set; }
        public bool NeedPassword { get; set; }
        public bool IsAnonymize { get; set; }
        public int StatusId { get; set; }
        public bool IsEveryOne { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
