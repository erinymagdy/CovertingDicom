using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Role
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleRights { get; set; }
        public string? RoleModalities { get; set; }
        public string? CustomerName { get; set; }
        public string? RoleRisPatientInfo { get; set; }
        public string? RoleRisStatusRights { get; set; }
        public string? RoleRisSiteInformationRights { get; set; }
        public string? RoleRisAccountingRights { get; set; }
        public string? RoleRisInventoryRights { get; set; }
        public string? RoleRisParticipationRights { get; set; }
        public string? RoleReportModality { get; set; }
    }
}
