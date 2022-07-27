using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathPostCathComp
    {
        public int PostCathIncId { get; set; }
        public int? PostCathCathDet { get; set; }
        public byte? PostCathCategory { get; set; }
        public byte? PostCathGen1 { get; set; }
        public byte? PostCathGen2 { get; set; }
        public byte? PostCathGen3 { get; set; }
        public byte? PostCathGen4 { get; set; }
        public byte? PostCathGen5 { get; set; }
        public byte? PostCathGen6 { get; set; }
        public byte? PostCathGen7 { get; set; }
        public byte? PostCathGen8 { get; set; }
        public byte? PostCathGen9 { get; set; }
        public byte? PostCathGen10 { get; set; }
        public byte? PostCathGen11 { get; set; }
        public byte? PostCathGen12 { get; set; }
        public byte? PostCathVas1 { get; set; }
        public byte? PostCathVas2 { get; set; }
        public byte? PostCathVas3 { get; set; }
        public byte? PostCathVas4 { get; set; }
        public byte? PostCathVas5 { get; set; }
        public byte? PostCathVas6 { get; set; }
        public byte? PostCathVas7 { get; set; }
        public byte? PostCathVas8 { get; set; }
        public byte? PostCathVas9 { get; set; }
        public byte? PostCathVas10 { get; set; }
        public byte? PostCathVas11 { get; set; }
        public byte? PostCathVas12 { get; set; }

        public virtual CathSr? PostCathCathDetNavigation { get; set; }
    }
}
