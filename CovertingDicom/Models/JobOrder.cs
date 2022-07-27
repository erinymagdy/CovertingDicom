using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class JobOrder
    {
        public int AccessionNoInc { get; set; }
        public string? AccessionNoStr { get; set; }
        public int? OrdPatIncIdDet { get; set; }
        public string? OrdPatId { get; set; }
        public string? OrdPatName { get; set; }
        public DateTime? OrdDatetime { get; set; }
        public byte? OrdPrintingStatus { get; set; }
        public string? OrdReceptionist { get; set; }
        public string? OrdComment { get; set; }
        public byte? EmergencyOrder { get; set; }

        public virtual Patient? OrdPatIncIdDetNavigation { get; set; }
    }
}
