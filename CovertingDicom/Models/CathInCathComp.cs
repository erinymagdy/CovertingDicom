using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathInCathComp
    {
        public int InCathIncId { get; set; }
        public int? InCathCathDet { get; set; }
        public byte? InCathCategory { get; set; }
        public byte? InCathGen1 { get; set; }
        public byte? InCathGen2 { get; set; }
        public byte? InCathGen3 { get; set; }
        public byte? InCathGen4 { get; set; }
        public byte? InCathGen5 { get; set; }
        public byte? InCathGen6 { get; set; }
        public byte? InCathGen7 { get; set; }
        public byte? InCathGen8 { get; set; }
        public byte? InCathGen9 { get; set; }
        public byte? InCathGen10 { get; set; }
        public byte? InCathGen11 { get; set; }
        public byte? InCathGen12 { get; set; }
        public byte? InCathVas1 { get; set; }
        public byte? InCathVas2 { get; set; }
        public byte? InCathVas3 { get; set; }
        public byte? InCathVas4 { get; set; }
        public byte? InCathVas5 { get; set; }
        public byte? InCathVas6 { get; set; }
        public byte? InCathVas7 { get; set; }
        public byte? InCathVas8 { get; set; }
        public byte? InCathVas9 { get; set; }
        public byte? InCathVas10 { get; set; }
        public byte? InCathVas11 { get; set; }
        public byte? InCathVas12 { get; set; }

        public virtual CathSr? InCathCathDetNavigation { get; set; }
    }
}
