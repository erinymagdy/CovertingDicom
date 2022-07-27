using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathLabMed
    {
        public int LabMedIncId { get; set; }
        public int? LabMedCathDet { get; set; }
        public byte? Lab1 { get; set; }
        public byte? Lab2 { get; set; }
        public byte? Lab3 { get; set; }
        public byte? Lab4 { get; set; }
        public byte? Lab5 { get; set; }
        public byte? Lab6 { get; set; }
        public byte? Lab7 { get; set; }

        public virtual CathSr? LabMedCathDetNavigation { get; set; }
    }
}
