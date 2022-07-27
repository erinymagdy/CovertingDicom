using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathDiag
    {
        public int DiagIncId { get; set; }
        public int? DiagCathDet { get; set; }
        public byte? DiagSegNumber { get; set; }
        public byte? DiagBranchAssessed { get; set; }
        public float? DiagBranchStenosis { get; set; }
        public byte? DiagBranchDenovoIsr { get; set; }
        public byte? DiagPreProcTimiFlow { get; set; }
        public byte? DiagBifurcationLesion { get; set; }
        public byte? DiagLargeThrombous { get; set; }
        public byte? DiagLesionExtemeAngulation { get; set; }
        public string? DiagPrevDilatationMethod { get; set; }
        public byte? DiagBranchGraftAccessed { get; set; }
        public float? DiagBranchGraftStenosis { get; set; }
        public byte? DiagBranchGraftDenovoIsr { get; set; }
        public byte? DiagBranchGraftArteryVien { get; set; }
        public byte? DiagBranchGraftLocationLesion { get; set; }

        public virtual CathSr? DiagCathDetNavigation { get; set; }
    }
}
