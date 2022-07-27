using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class User
    {
        public User()
        {
            UserBranches = new HashSet<UserBranch>();
            UsersParticipations = new HashSet<UsersParticipation>();
            UsersProcs = new HashSet<UsersProc>();
        }

        public int UId { get; set; }
        public string? UName { get; set; }
        public string? UPassword { get; set; }
        public string? UJobTitle { get; set; }
        public string? USex { get; set; }
        public string? UAddress { get; set; }
        public string? UFullname { get; set; }
        public DateTime? UBirthdate { get; set; }
        public string? UComment { get; set; }
        public string? UTel { get; set; }
        public string? UMobile { get; set; }
        public string? UEmail { get; set; }
        public string? UFaxNumber { get; set; }
        public string? UTel2 { get; set; }
        public string? UAddress2 { get; set; }
        public byte? UJobCategory { get; set; }
        public string? UPopMail { get; set; }
        public string? UPopMailPassword { get; set; }
        public string? USmtpMail { get; set; }
        public string? USmtpMailPassword { get; set; }
        public string? USignatureFilePath { get; set; }
        public string? RModalities { get; set; }
        public string? UMirisProfile { get; set; }
        public string? UVtoolsProfile { get; set; }
        public string? UMireportProfile { get; set; }
        public string? UDirectory { get; set; }
        public int? RImages { get; set; }
        public int? RReports { get; set; }
        public int? RMovies { get; set; }
        public int? RVoices { get; set; }
        public int? RPatInfo { get; set; }
        public int? RCommonInfo { get; set; }
        public int? RAccountingInfo { get; set; }
        public int? RAccountingReports { get; set; }
        public int? RInventoryInfo { get; set; }
        public int? RInventoryReports { get; set; }
        public int? RCommonInventoryInfo { get; set; }
        public int? RUpdateSettings { get; set; }
        public int? RReportSections { get; set; }
        public int? RReportTemplates { get; set; }
        public int? RReportStructure { get; set; }
        public int? RBranches { get; set; }
        public string? RStatus { get; set; }
        public byte? URestriction { get; set; }
        public DateTime? URestrictionFrom { get; set; }
        public DateTime? URestrictionTo { get; set; }
        public string? URestrictionComment { get; set; }
        public int? RConsumptionInventory { get; set; }
        public string? UPopServer { get; set; }
        public int? UPopPort { get; set; }
        public string? USmtpServer { get; set; }
        public int? USmtpPort { get; set; }
        public string? RParticipation { get; set; }
        public int? AccountType { get; set; }
        public DateTime? AccountStartDate { get; set; }
        public DateTime? AccountExpireDate { get; set; }
        public string? DocUsers { get; set; }
        public string? RefUsers { get; set; }
        public string? AllowedBranches { get; set; }
        public string? RepStat { get; set; }
        public string? DefaultBranch { get; set; }
        public int? ULanguage { get; set; }
        public int? UCode { get; set; }
        public string? UCustomerName { get; set; }
        public short? PasswordRenewalPeriod { get; set; }
        public DateTime? PasswordRenewalDate { get; set; }
        public string? QuestionCode { get; set; }
        public string? QuestionAnswer { get; set; }
        public string? UserStudies { get; set; }
        public string? Otptoken { get; set; }
        public string? UCvFilePath { get; set; }
        public bool? CpView { get; set; }
        public string? EmrProviderName { get; set; }
        public string? HPassword { get; set; }
        public string? DomainGuid { get; set; }
        public string? UserSettings { get; set; }
        public byte ULocked { get; set; }
        public DateTime? ULockedDate { get; set; }

        public virtual ICollection<UserBranch> UserBranches { get; set; }
        public virtual ICollection<UsersParticipation> UsersParticipations { get; set; }
        public virtual ICollection<UsersProc> UsersProcs { get; set; }
    }
}
