using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class AuditLog
    {
        public int AuditIncId { get; set; }
        public string? AuditPatId { get; set; }
        public string? AuditPatName { get; set; }
        public int? AuditStudyId { get; set; }
        public string? AuditAccNo { get; set; }
        public string? AuditProcName { get; set; }
        public string? AuditUserName { get; set; }
        public byte? AuditUserCategory { get; set; }
        public DateTime? AuditDate { get; set; }
        public string? AuditType { get; set; }
        public string? AuditLocation { get; set; }
        public string? AuditModule { get; set; }
        public string? AuditBranch { get; set; }
        public string? AuditComment { get; set; }
    }
}
