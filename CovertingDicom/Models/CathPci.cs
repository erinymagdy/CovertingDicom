using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathPci
    {
        public CathPci()
        {
            CathPciBalloons = new HashSet<CathPciBalloon>();
            CathPciStents = new HashSet<CathPciStent>();
        }

        public int PciIncId { get; set; }
        public int? PciCathDet { get; set; }
        public byte? PciSegNumber { get; set; }
        public float? PciPostProcStenosis { get; set; }
        public byte? PciPostProcTimiFlow { get; set; }
        public byte? PciGuidingCathLength { get; set; }
        public byte? PciGuidingWireFloppyNumber { get; set; }
        public string? PciGuidingWireFloppyTradeName { get; set; }
        public byte? PciGuidingWireIntermediateNumber { get; set; }
        public string? PciGuidingWireIntermediateTradeName { get; set; }
        public byte? PciGuidingWireStiffNumber { get; set; }
        public string? PciGuidingWireStiffTradeName { get; set; }
        public byte? PciBallonPreDilatation { get; set; }
        public byte? PciStentCount { get; set; }
        public byte? PciDissection { get; set; }
        public byte? PciAcuteClosure { get; set; }
        public byte? PciAcuteClosureSuccessfulReopening { get; set; }
        public byte? PciNoReflowPhenom { get; set; }
        public byte? PciPerforation { get; set; }
        public byte? PciType { get; set; }

        public virtual CathSr? PciCathDetNavigation { get; set; }
        public virtual ICollection<CathPciBalloon> CathPciBalloons { get; set; }
        public virtual ICollection<CathPciStent> CathPciStents { get; set; }
    }
}
