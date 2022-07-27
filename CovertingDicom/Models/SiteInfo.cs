using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class SiteInfo
    {
        public int SiteInfoId { get; set; }
        public string UltimaIp { get; set; } = null!;
        public int SslPort { get; set; }
        public bool IsWindowsAuth { get; set; }
        public string? CustDir { get; set; }
    }
}
