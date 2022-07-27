using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoFollowUpAction
    {
        public int ActionIncId { get; set; }
        public int? FollowUpIncId { get; set; }
        public int? ActionId { get; set; }
        public int? ActionTypeId { get; set; }
        public DateTime? ActionDate { get; set; }
        public string? Notes { get; set; }
        public int? UId { get; set; }

        public virtual MammoFollowUp? FollowUpInc { get; set; }
    }
}
