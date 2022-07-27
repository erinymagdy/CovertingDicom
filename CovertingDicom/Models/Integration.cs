using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Integration
    {
        public int IntegrationIncId { get; set; }
        public int BranchCode { get; set; }
        public string Url { get; set; } = null!;
        public string UrlDescription { get; set; } = null!;

        public virtual Branch BranchCodeNavigation { get; set; } = null!;
    }
}
