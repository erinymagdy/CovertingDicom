using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class UserBranch
    {
        public int URId { get; set; }
        public int UserIdDet { get; set; }
        public string BranchName { get; set; } = null!;
        public DateTime? AccountStartDate { get; set; }
        public DateTime? AccountExpireDate { get; set; }
        public byte? AccountType { get; set; }
        public string? DocUsers { get; set; }
        public string? RefUsers { get; set; }
        public string? RepStat { get; set; }
        public string? UDirectory { get; set; }
        public string? USignatureFilePath { get; set; }
        public int? RoleId { get; set; }
        public int? CpRoleId { get; set; }

        public virtual User UserIdDetNavigation { get; set; } = null!;
    }
}
