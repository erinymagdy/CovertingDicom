using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Report
    {
        public Report()
        {
            CathSrs = new HashSet<CathSr>();
        }

        public int RepIncId { get; set; }
        public int? RepStudyIncIdDet { get; set; }
        public string? RepFilePath { get; set; }
        public string? RepStructureTabName { get; set; }
        public byte? RepType { get; set; }
        public string? RepName { get; set; }
        public string? RepComment { get; set; }
        public DateTime? RepStatusDate { get; set; }
        public byte? RepStatus { get; set; }
        public string? RepTypist { get; set; }
        public string? RepAuditUser { get; set; }
        public string? RepVerifyUser { get; set; }
        public string? RepDictateUser { get; set; }

        public virtual Study? RepStudyIncIdDetNavigation { get; set; }
        public virtual ICollection<CathSr> CathSrs { get; set; }
    }
}
