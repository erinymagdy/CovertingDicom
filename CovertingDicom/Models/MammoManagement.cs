using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MammoManagement
    {
        public int ManagementIncId { get; set; }
        public int? FollowUpIncId { get; set; }
        public int? BreastSide { get; set; }
        public int? Management { get; set; }

        public virtual MammoFollowUp? FollowUpInc { get; set; }
    }
}
