using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class UsersProc
    {
        public int UProcIncId { get; set; }
        public string? UFullname { get; set; }
        public string? ProcName { get; set; }
        public float? UProcPerc { get; set; }
        public float? UProcValue { get; set; }
        public float? UProcPartPerc1 { get; set; }
        public float? UProcPartPerc2 { get; set; }
        public int? UIdDet { get; set; }
        public int? ProcCodeDet { get; set; }

        public virtual Procedure? ProcCodeDetNavigation { get; set; }
        public virtual User? UIdDetNavigation { get; set; }
    }
}
