using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class LifeCycleManager
    {
        public int LifecycleIncId { get; set; }
        public int? StudyIncId { get; set; }
        public string? StudyId { get; set; }
        public string? PatId { get; set; }
        public string? PatName { get; set; }
        public byte? ActionId { get; set; }
        public double? ActionDateTime { get; set; }
        public string? RemotePacs { get; set; }
        public string? DestinationDirectory { get; set; }
        public string? Customer { get; set; }
        public string? Branch { get; set; }
        public string? Modality { get; set; }
        public string? AccessionNo { get; set; }
    }
}
