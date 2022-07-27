using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class StudyLock
    {
        public int? StudyIncIdDet { get; set; }
        public string? Ipaddress { get; set; }
        public string? UserName { get; set; }
        public DateTime? LockTime { get; set; }
        public int? AppType { get; set; }

        public virtual Study? StudyIncIdDetNavigation { get; set; }
    }
}
