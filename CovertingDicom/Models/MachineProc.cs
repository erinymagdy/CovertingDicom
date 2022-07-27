using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class MachineProc
    {
        public int MachineProcInc { get; set; }
        public int? MachineCode { get; set; }
        public int? ProcCode { get; set; }
    }
}
