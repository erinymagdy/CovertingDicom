using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class RolesCp
    {
        public int CpRoleId { get; set; }
        public string? CpRoleName { get; set; }
        public string? CpRoleRights { get; set; }
        public string? CustomerName { get; set; }
        public string? CpBranchName { get; set; }
    }
}
