using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Machine
    {
        public int MachineCode { get; set; }
        public string? MachineName { get; set; }
        public string? RoomName { get; set; }
        public string? ModalityName { get; set; }
        public string? BranchName { get; set; }
        public string? AeTitle { get; set; }
        public string? MachineIpAddress { get; set; }
        public short? MachinePortNumber { get; set; }
        public byte? LocalMachine { get; set; }
        public byte? MachineUseWl { get; set; }
        public byte? MachineRestriction { get; set; }
        public DateTime? MachineRestrictionFrom { get; set; }
        public DateTime? MachineRestrictionTo { get; set; }
        public string? MachineRestrictionComment { get; set; }
        public int? BranchCode { get; set; }
    }
}
