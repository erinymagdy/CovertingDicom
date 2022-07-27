using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class UsersParticipation
    {
        public int ParticipationIncId { get; set; }
        public int? ParticipationStudyDet { get; set; }
        public string? ParticipationUserName { get; set; }
        public string? ParticipationComment { get; set; }
        public DateTime? ParticipationDate { get; set; }
        public float? UValue { get; set; }
        public float? UProcPerc { get; set; }
        public float? UProcValue { get; set; }
        public float UProcPartPerc1 { get; set; }
        public float UProcPartPerc2 { get; set; }
        public int? UIdDet { get; set; }
        public byte? UserType { get; set; }

        public virtual Study? ParticipationStudyDetNavigation { get; set; }
        public virtual User? UIdDetNavigation { get; set; }
    }
}
