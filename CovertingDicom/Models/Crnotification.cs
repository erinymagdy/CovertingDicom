using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Crnotification
    {
        public int CrnotificationId { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public int GroupId { get; set; }
        public string? ReceiverName { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool HasAcknowledge { get; set; }
        public string? Notes { get; set; }
        public string CustomerName { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public int StudyIncId { get; set; }
        public byte ActionId { get; set; }
        public int? MdId { get; set; }
        public byte? HasNotified { get; set; }
    }
}
