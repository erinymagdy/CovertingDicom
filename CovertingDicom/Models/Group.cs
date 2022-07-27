using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Group
    {
        public int GroupIncId { get; set; }
        public int? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? GroupPermissions { get; set; }
        public string? CustomerName { get; set; }
    }
}
