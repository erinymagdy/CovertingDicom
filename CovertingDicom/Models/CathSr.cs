using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class CathSr
    {
        public CathSr()
        {
            CathDiags = new HashSet<CathDiag>();
            CathHists = new HashSet<CathHist>();
            CathInCathComps = new HashSet<CathInCathComp>();
            CathLabMeds = new HashSet<CathLabMed>();
            CathMeds = new HashSet<CathMed>();
            CathPcis = new HashSet<CathPci>();
            CathPostCathComps = new HashSet<CathPostCathComp>();
        }

        public int CathIncId { get; set; }
        public int? CathReportsDet { get; set; }
        public DateTime? CathDateTime { get; set; }
        public string? CathDiagOperatorName { get; set; }
        public string? CathDiagAssistantName { get; set; }
        public DateTime? CathDiagProcDate { get; set; }
        public byte? CathDiagStatus { get; set; }
        public byte? CathDiagIndications { get; set; }
        public byte? CathDiagProcType { get; set; }
        public byte? CathDiagPrecoutanousEntry { get; set; }
        public byte? CathDiagMitralStenosis { get; set; }
        public byte? CathDiagMitralInsufficiency { get; set; }
        public byte? CathDiagMitralLvEdp { get; set; }
        public byte? CathDiagMitralMeanLa { get; set; }
        public byte? CathDiagMitralPg { get; set; }
        public byte? CathDiagAorticStenosis { get; set; }
        public byte? CathDiagAorticInsufficiency { get; set; }
        public int? CathDiagAorticLvSbp { get; set; }
        public int? CathDiagAorticAoSbp { get; set; }
        public int? CathDiagAorticPg { get; set; }
        public byte? CathDiagPulmStenosis { get; set; }
        public byte? CathDiagPulmInsufficiency { get; set; }
        public byte? CathDiagPulmRvSbp { get; set; }
        public byte? CathDiagPulmPaSbp { get; set; }
        public byte? CathDiagPulmPg { get; set; }
        public byte? CathDiagTricuspidStenosis { get; set; }
        public byte? CathDiagTricuspidInsufficiency { get; set; }
        public byte? CathDiagTricuspidRvEdp { get; set; }
        public byte? CathDiagTricuspidMeanRa { get; set; }
        public byte? CathDiagTricuspidPg { get; set; }
        public byte? CathDiagLvGram { get; set; }
        public byte? CathDiagWallMotion { get; set; }
        public float? CathDiagEf { get; set; }
        public byte? CathDiagEfObtainedBy { get; set; }
        public string? CathPciOperatorName { get; set; }
        public string? CathPciAssistantName { get; set; }
        public DateTime? CathPciProcDate { get; set; }
        public byte? CathPciStatus { get; set; }
        public byte? CathPreProcMi { get; set; }
        public int? CathPreProcCkBaseline { get; set; }
        public int? CathPreProcCkPeak { get; set; }
        public int? CathPreProcCkMbBaseline { get; set; }
        public int? CathPreProcCkMbPeak { get; set; }
        public int? CathPreProcNewQWaves { get; set; }
        public string? CathTreatmentSummary { get; set; }
        public string? CathMedSummary { get; set; }
        public string? CathHistSummary { get; set; }
        public string? CathDiagSummary { get; set; }
        public string? CathPciSummary { get; set; }
        public string? CathCompSummary { get; set; }
        public byte? CathDischargeType { get; set; }
        public DateTime? CathDischargeDate { get; set; }
        public DateTime? CathDeathDate { get; set; }
        public byte? CathDeathTime { get; set; }
        public byte? CathDeathPrimaryCauseOfDeath { get; set; }

        public virtual Report? CathReportsDetNavigation { get; set; }
        public virtual ICollection<CathDiag> CathDiags { get; set; }
        public virtual ICollection<CathHist> CathHists { get; set; }
        public virtual ICollection<CathInCathComp> CathInCathComps { get; set; }
        public virtual ICollection<CathLabMed> CathLabMeds { get; set; }
        public virtual ICollection<CathMed> CathMeds { get; set; }
        public virtual ICollection<CathPci> CathPcis { get; set; }
        public virtual ICollection<CathPostCathComp> CathPostCathComps { get; set; }
    }
}
