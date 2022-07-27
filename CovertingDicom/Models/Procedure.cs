using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Procedure
    {
        public Procedure()
        {
            UsersProcs = new HashSet<UsersProc>();
        }

        public int ProcCode { get; set; }
        public string? ProcId { get; set; }
        public string? ProcName { get; set; }
        public string? ProcNameStandard { get; set; }
        public string? ModalityName { get; set; }
        public string? BodyPart { get; set; }
        public float? ProcPrice { get; set; }
        public float? ProcDuration { get; set; }
        public byte? WeightCheck { get; set; }
        public byte? NoVisit { get; set; }
        public string? ProcComment { get; set; }
        public string? ProcNameOther { get; set; }
        public int? CustomerId { get; set; }

        public virtual ICollection<UsersProc> UsersProcs { get; set; }
    }
}
