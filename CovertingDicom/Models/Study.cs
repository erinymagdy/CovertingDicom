using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Study
    {
        public Study()
        {
            Accountings = new HashSet<Accounting>();
            MammoFollowUps = new HashSet<MammoFollowUp>();
            MammoSFeedbacks = new HashSet<MammoSFeedback>();
            MammoSReports = new HashSet<MammoSReport>();
            Reports = new HashSet<Report>();
            Series = new HashSet<Series>();
            StudyDetails = new HashSet<StudyDetail>();
            UsersParticipations = new HashSet<UsersParticipation>();
        }

        public int StudyIncId { get; set; }
        public string? StudyIncIdStr { get; set; }
        public int? AccessionNoIncDet { get; set; }
        public string? AccessionNoDetStr { get; set; }
        public int? PatIncIdDet { get; set; }
        public string? StudyId { get; set; }
        public float? PatWeight { get; set; }
        public float? PatHeight { get; set; }
        public string? StudyUid { get; set; }
        public string? StudyDescription { get; set; }
        public string? RpDescription { get; set; }
        public string? AeTitle { get; set; }
        public byte? UseWl { get; set; }
        public string? StudyLocation { get; set; }
        public string? StudyDirectory { get; set; }
        public string? BranchName { get; set; }
        public DateTime? ProcStart { get; set; }
        public DateTime? ProcEnd { get; set; }
        public string? StudyReceptionist { get; set; }
        public string? ProcName { get; set; }
        public string? ModalityName { get; set; }
        public string? MachineName { get; set; }
        public string? RoomName { get; set; }
        public string? RefPhyName { get; set; }
        public string? RadiologistName { get; set; }
        public string? InsurName { get; set; }
        public byte? InsurPaymentMethod { get; set; }
        public string? HandledName { get; set; }
        public DateTime? HandledDate { get; set; }
        public byte? StatusReported { get; set; }
        public byte? StatusRis { get; set; }
        public byte? StatusProtected { get; set; }
        public byte? StatusViewed { get; set; }
        public byte? StatusArchived { get; set; }
        public int? StudySeries { get; set; }
        public int? StudyImages { get; set; }
        public int? StudyCines { get; set; }
        public int? StudyVoices { get; set; }
        public int? StudyReports { get; set; }
        public string? MppsUid { get; set; }
        public string? StudyFindSystem { get; set; }
        public string? StudyFindCategory { get; set; }
        public string? StudyFindDesc { get; set; }
        public int? StudyRbs { get; set; }
        public int? StudyBpLow { get; set; }
        public int? StudyBpHigh { get; set; }
        public string? ModalitiesInStudy { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public string? ReportVerifier { get; set; }
        public string? ReportAuditor { get; set; }
        public string? ReportDictator { get; set; }
        public string? ReportTypist { get; set; }
        public string? CustomerName { get; set; }
        public string? StatusTransferredTo { get; set; }
        public string? StudyKeyword { get; set; }
        public byte? Education { get; set; }
        public byte? StatusTransferred { get; set; }
        public byte? StatusStat { get; set; }
        public int? PeriodIncId { get; set; }
        public byte? PeerReviewStatus { get; set; }
        public byte? EdStatus { get; set; }
        public string? InstitutionName { get; set; }
        public byte? CrStatus { get; set; }
        public string? Technician { get; set; }
        public string? Reasons { get; set; }
        public string? Comments { get; set; }
        public string? InsurType { get; set; }
        public byte IsCanceled { get; set; }
        public byte? AppType { get; set; }

        public virtual Patient? PatIncIdDetNavigation { get; set; }
        public virtual ICollection<Accounting> Accountings { get; set; }
        public virtual ICollection<MammoFollowUp> MammoFollowUps { get; set; }
        public virtual ICollection<MammoSFeedback> MammoSFeedbacks { get; set; }
        public virtual ICollection<MammoSReport> MammoSReports { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Series> Series { get; set; }
        public virtual ICollection<StudyDetail> StudyDetails { get; set; }
        public virtual ICollection<UsersParticipation> UsersParticipations { get; set; }
    }
}
