using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathMed
    {
        public int MedIncId { get; set; }
        public int? MedCathDet { get; set; }
        public byte? Med1 { get; set; }
        public byte? Med2 { get; set; }
        public byte? Med3 { get; set; }
        public byte? Med4 { get; set; }
        public byte? Med5 { get; set; }
        public byte? Med6 { get; set; }
        public byte? Med7 { get; set; }
        public byte? Med8 { get; set; }
        public byte? Med9 { get; set; }
        public byte? Med10 { get; set; }
        public byte? Med11 { get; set; }
        public byte? Med12 { get; set; }
        public byte? Med13 { get; set; }
        public byte? Med14 { get; set; }
        public byte? Med15 { get; set; }

        public virtual CathSr? MedCathDetNavigation { get; set; }
    }
}
