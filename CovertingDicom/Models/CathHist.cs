using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathHist
    {
        public int HistIncId { get; set; }
        public int? HistCathDet { get; set; }
        public DateTime? HistPerviousPci { get; set; }
        public DateTime? HistPerviousCabg { get; set; }
        public DateTime? HistPerviousValveSurgery { get; set; }
        public byte? HistChf { get; set; }
        public byte? HistCardioShock { get; set; }
        public byte? HistNonInvTestInchemia { get; set; }
        public byte? HistAngina { get; set; }
        public byte? HistAcsTimePeriod { get; set; }
        public byte? His1 { get; set; }
        public byte? His2 { get; set; }
        public byte? His4 { get; set; }
        public byte? His5 { get; set; }
        public byte? His6 { get; set; }
        public byte? His7 { get; set; }
        public byte? His8 { get; set; }
        public byte? His9 { get; set; }
        public byte? His10 { get; set; }
        public byte? His11 { get; set; }

        public virtual CathSr? HistCathDetNavigation { get; set; }
    }
}
