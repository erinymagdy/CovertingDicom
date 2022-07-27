using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class ProcDetail
    {
        public int ProcDetailIncCode { get; set; }
        public string? ProcName { get; set; }
        public string? RoomName { get; set; }
        public string? MachineName { get; set; }
    }
}
