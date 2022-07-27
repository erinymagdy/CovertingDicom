using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoFollowUp
    {
        public MammoFollowUp()
        {
            MammoFollowUpActions = new HashSet<MammoFollowUpAction>();
            MammoManagements = new HashSet<MammoManagement>();
        }

        public int FollowUpIncId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? FollowUpStatus { get; set; }
        public int? StudyIncId { get; set; }

        public virtual Study? StudyInc { get; set; }
        public virtual ICollection<MammoFollowUpAction> MammoFollowUpActions { get; set; }
        public virtual ICollection<MammoManagement> MammoManagements { get; set; }
    }
}
