using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CovertingDicom.Models
{
    public partial class MIGlobalContext : DbContext
    {
        public MIGlobalContext()
        {
        }

        public MIGlobalContext(DbContextOptions<MIGlobalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounting> Accountings { get; set; } = null!;
        public virtual DbSet<AccountingTran> AccountingTrans { get; set; } = null!;
        public virtual DbSet<Additional> Additionals { get; set; } = null!;
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<CathDiag> CathDiags { get; set; } = null!;
        public virtual DbSet<CathHist> CathHists { get; set; } = null!;
        public virtual DbSet<CathInCathComp> CathInCathComps { get; set; } = null!;
        public virtual DbSet<CathItem> CathItems { get; set; } = null!;
        public virtual DbSet<CathItemValue> CathItemValues { get; set; } = null!;
        public virtual DbSet<CathLabMed> CathLabMeds { get; set; } = null!;
        public virtual DbSet<CathMed> CathMeds { get; set; } = null!;
        public virtual DbSet<CathPci> CathPcis { get; set; } = null!;
        public virtual DbSet<CathPciBalloon> CathPciBalloons { get; set; } = null!;
        public virtual DbSet<CathPciStent> CathPciStents { get; set; } = null!;
        public virtual DbSet<CathPostCathComp> CathPostCathComps { get; set; } = null!;
        public virtual DbSet<CathSr> CathSrs { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Crnotification> Crnotifications { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<DbComment> DbComments { get; set; } = null!;
        public virtual DbSet<Dic> Dics { get; set; } = null!;
        public virtual DbSet<Echo> Echoes { get; set; } = null!;
        public virtual DbSet<EdDiscrepancy> EdDiscrepancies { get; set; } = null!;
        public virtual DbSet<FindingCategory> FindingCategories { get; set; } = null!;
        public virtual DbSet<FindingDesc> FindingDescs { get; set; } = null!;
        public virtual DbSet<FindingSystem> FindingSystems { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<InstInfo> InstInfos { get; set; } = null!;
        public virtual DbSet<Integration> Integrations { get; set; } = null!;
        public virtual DbSet<JobOrder> JobOrders { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<LanguageCustomer> LanguageCustomers { get; set; } = null!;
        public virtual DbSet<LifeCycleManager> LifeCycleManagers { get; set; } = null!;
        public virtual DbSet<Machine> Machines { get; set; } = null!;
        public virtual DbSet<MachineProc> MachineProcs { get; set; } = null!;
        public virtual DbSet<MammoFollowUp> MammoFollowUps { get; set; } = null!;
        public virtual DbSet<MammoFollowUpAction> MammoFollowUpActions { get; set; } = null!;
        public virtual DbSet<MammoManagement> MammoManagements { get; set; } = null!;
        public virtual DbSet<MammoSFeedback> MammoSFeedbacks { get; set; } = null!;
        public virtual DbSet<MammoSLesion> MammoSLesions { get; set; } = null!;
        public virtual DbSet<MammoSReport> MammoSReports { get; set; } = null!;
        public virtual DbSet<Md> Mds { get; set; } = null!;
        public virtual DbSet<Modality> Modalities { get; set; } = null!;
        public virtual DbSet<ModalityLocal> ModalityLocals { get; set; } = null!;
        public virtual DbSet<ModalityUser> ModalityUsers { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PeerReview> PeerReviews { get; set; } = null!;
        public virtual DbSet<PeerReviewConfig> PeerReviewConfigs { get; set; } = null!;
        public virtual DbSet<PeerReviewPeriod> PeerReviewPeriods { get; set; } = null!;
        public virtual DbSet<Prefix> Prefixes { get; set; } = null!;
        public virtual DbSet<ProcDetail> ProcDetails { get; set; } = null!;
        public virtual DbSet<Procedure> Procedures { get; set; } = null!;
        public virtual DbSet<ReferringPhysician> ReferringPhysicians { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolesCp> RolesCps { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<SendingFile> SendingFiles { get; set; } = null!;
        public virtual DbSet<SendingStudy> SendingStudies { get; set; } = null!;
        public virtual DbSet<Series> Series { get; set; } = null!;
        public virtual DbSet<SharedStudiesUser> SharedStudiesUsers { get; set; } = null!;
        public virtual DbSet<SharedStudy> SharedStudies { get; set; } = null!;
        public virtual DbSet<SiteInfo> SiteInfos { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Study> Studies { get; set; } = null!;
        public virtual DbSet<StudyDetail> StudyDetails { get; set; } = null!;
        public virtual DbSet<StudyInsur> StudyInsurs { get; set; } = null!;
        public virtual DbSet<StudyLock> StudyLocks { get; set; } = null!;
        public virtual DbSet<TimeZone> TimeZones { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserBranch> UserBranches { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<UsersParticipation> UsersParticipations { get; set; } = null!;
        public virtual DbSet<UsersProc> UsersProcs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\local;Initial Catalog=MIGlobal;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Arabic_CI_AS");

            modelBuilder.Entity<Accounting>(entity =>
            {
                entity.HasKey(e => e.AccountIncId)
                    .HasName("Account_Inc_ID");

                entity.ToTable("Accounting");

                entity.Property(e => e.AccountIncId).HasColumnName("Account_Inc_ID");

                entity.Property(e => e.AccountReceptionist)
                    .HasMaxLength(50)
                    .HasColumnName("Account_Receptionist");

                entity.Property(e => e.AdditionUser)
                    .HasMaxLength(50)
                    .HasColumnName("Addition_User");

                entity.Property(e => e.AdditionalComment)
                    .HasMaxLength(255)
                    .HasColumnName("additional_comment");

                entity.Property(e => e.AdditionalValue)
                    .HasColumnName("additional_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArrivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Arrived_Date");

                entity.Property(e => e.ArrivedUser)
                    .HasMaxLength(50)
                    .HasColumnName("Arrived_User");

                entity.Property(e => e.CanceledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Canceled_Date");

                entity.Property(e => e.CanceledReason)
                    .HasMaxLength(500)
                    .HasColumnName("Canceled_Reason");

                entity.Property(e => e.CanceledUser)
                    .HasMaxLength(50)
                    .HasColumnName("Canceled_User");

                entity.Property(e => e.CompletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Completed_Date");

                entity.Property(e => e.CompletedUser)
                    .HasMaxLength(50)
                    .HasColumnName("Completed_User");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.DepositDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Deposit_Date");

                entity.Property(e => e.DepositUser)
                    .HasMaxLength(50)
                    .HasColumnName("Deposit_User");

                entity.Property(e => e.DepositValue)
                    .HasColumnName("Deposit_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscontinueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Discontinue_Date");

                entity.Property(e => e.DiscontinueUser)
                    .HasMaxLength(50)
                    .HasColumnName("Discontinue_User");

                entity.Property(e => e.DiscountComment)
                    .HasMaxLength(255)
                    .HasColumnName("discount_comment");

                entity.Property(e => e.DiscountUser)
                    .HasMaxLength(50)
                    .HasColumnName("Discount_User");

                entity.Property(e => e.DiscountValue)
                    .HasColumnName("discount_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HandledAllDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HandledAll_Date");

                entity.Property(e => e.HandledAllUser)
                    .HasMaxLength(50)
                    .HasColumnName("HandledAll_User");

                entity.Property(e => e.HandledByName)
                    .HasMaxLength(50)
                    .HasColumnName("HandledBy_Name");

                entity.Property(e => e.HandledFilmOnlyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HandledFilmOnly_Date");

                entity.Property(e => e.HandledFilmOnlyUser)
                    .HasMaxLength(50)
                    .HasColumnName("HandledFilmOnly_User");

                entity.Property(e => e.HandledReportOnlyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HandledReportOnly_Date");

                entity.Property(e => e.HandledReportOnlyUser)
                    .HasMaxLength(50)
                    .HasColumnName("HandledReportOnly_User");

                entity.Property(e => e.InProgressDate)
                    .HasColumnType("datetime")
                    .HasColumnName("InProgress_Date");

                entity.Property(e => e.InProgressUser)
                    .HasMaxLength(50)
                    .HasColumnName("InProgress_User");

                entity.Property(e => e.InsurProcMainPrice)
                    .HasColumnName("Insur_Proc_Main_Price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurProcPrice)
                    .HasColumnName("Insur_Proc_Price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurReturnAmount)
                    .HasColumnName("Insur_Return_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Insur_Return_Date");

                entity.Property(e => e.InsurReturnUser)
                    .HasMaxLength(50)
                    .HasColumnName("Insur_Return_User");

                entity.Property(e => e.PayeeInsurNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Payee_Insur_No");

                entity.Property(e => e.PayeeName)
                    .HasMaxLength(50)
                    .HasColumnName("Payee_Name");

                entity.Property(e => e.PayeeRelationship)
                    .HasMaxLength(50)
                    .HasColumnName("Payee_Relationship");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Payment_Date");

                entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");

                entity.Property(e => e.PaymentValue)
                    .HasColumnName("payment_value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PendingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Pending_Date");

                entity.Property(e => e.PendingUser)
                    .HasMaxLength(50)
                    .HasColumnName("Pending_User");

                entity.Property(e => e.ProcPrice)
                    .HasColumnName("proc_price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiptNoOther)
                    .HasColumnName("Receipt_No_Other")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecipteNumber).HasColumnName("recipte_number");

                entity.Property(e => e.RemPaidCash2)
                    .HasColumnName("Rem_Paid_Cash_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemPaidCash2Date)
                    .HasColumnType("datetime")
                    .HasColumnName("Rem_Paid_Cash_2_Date");

                entity.Property(e => e.RemPaidCash2User)
                    .HasMaxLength(50)
                    .HasColumnName("Rem_Paid_Cash_2_User");

                entity.Property(e => e.RemPaidCashUser)
                    .HasMaxLength(50)
                    .HasColumnName("Rem_Paid_Cash_User");

                entity.Property(e => e.RemPaidVisa2)
                    .HasColumnName("Rem_Paid_Visa_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemPaidVisa2Date)
                    .HasColumnType("datetime")
                    .HasColumnName("Rem_Paid_Visa_2_Date");

                entity.Property(e => e.RemPaidVisa2User)
                    .HasMaxLength(50)
                    .HasColumnName("Rem_Paid_Visa_2_User");

                entity.Property(e => e.RemPaidVisaUser)
                    .HasMaxLength(50)
                    .HasColumnName("Rem_Paid_Visa_User");

                entity.Property(e => e.RemainderPaid)
                    .HasColumnName("remainder_paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainderPaidVisa)
                    .HasColumnName("Remainder_Paid_Visa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemainderPaidVisaDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Remainder_Paid_Visa_Date");

                entity.Property(e => e.RemainderPaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("remainder_payment_date");

                entity.Property(e => e.ReturnAmount)
                    .HasColumnName("return_amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReturnComment)
                    .HasMaxLength(255)
                    .HasColumnName("return_comment");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("datetime")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnUser)
                    .HasMaxLength(50)
                    .HasColumnName("Return_User");

                entity.Property(e => e.ScheduledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Scheduled_Date");

                entity.Property(e => e.ScheduledUser)
                    .HasMaxLength(50)
                    .HasColumnName("Scheduled_User");

                entity.Property(e => e.StudyIncIdDet).HasColumnName("Study_Inc_ID_Det");

                entity.Property(e => e.VisaValue)
                    .HasColumnName("Visa_Value")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.StudyIncIdDetNavigation)
                    .WithMany(p => p.Accountings)
                    .HasForeignKey(d => d.StudyIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Study_Inc_ID_Study_Inc_ID_det");
            });

            modelBuilder.Entity<AccountingTran>(entity =>
            {
                entity.HasKey(e => e.TransIncId)
                    .HasName("Trans_Inc_ID");

                entity.ToTable("Accounting_Trans");

                entity.Property(e => e.TransIncId).HasColumnName("Trans_Inc_ID");

                entity.Property(e => e.AccountIncId).HasColumnName("Account_Inc_ID");

                entity.Property(e => e.ProcessType)
                    .HasColumnName("Process_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransAdditionalValue)
                    .HasColumnName("Trans_Additional_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");

                entity.Property(e => e.TransDepositValue)
                    .HasColumnName("Trans_Deposit_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransDiscountValue)
                    .HasColumnName("Trans_Discount_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransItemCode).HasColumnName("Trans_ItemCode");

                entity.Property(e => e.TransPaymentValue)
                    .HasColumnName("Trans_Payment_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransProcPrice)
                    .HasColumnName("Trans_Proc_Price")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransReceiptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Receipt_Date");

                entity.Property(e => e.TransReceiptNo)
                    .HasColumnName("Trans_Receipt_No")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransRemainderPaid)
                    .HasColumnName("Trans_Remainder_Paid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransRemainderPaidVisa)
                    .HasColumnName("Trans_Remainder_Paid_Visa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransReturnAmount)
                    .HasColumnName("Trans_Return_Amount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransType)
                    .HasColumnName("Trans_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransUserName)
                    .HasMaxLength(50)
                    .HasColumnName("Trans_User_Name");

                entity.Property(e => e.TransVisaValue)
                    .HasColumnName("Trans_Visa_Value")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AccountInc)
                    .WithMany(p => p.AccountingTrans)
                    .HasForeignKey(d => d.AccountIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Accounting_Transactions");
            });

            modelBuilder.Entity<Additional>(entity =>
            {
                entity.HasKey(e => e.AddCode)
                    .HasName("PK__Addition__ADF69161700934B0");

                entity.Property(e => e.AddCode).HasColumnName("Add_code");

                entity.Property(e => e.AddName)
                    .HasMaxLength(50)
                    .HasColumnName("Add_name");

                entity.Property(e => e.AddNameStandard)
                    .HasMaxLength(50)
                    .HasColumnName("Add_name_standard");

                entity.Property(e => e.AddPrice).HasColumnName("Add_price");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Additionals)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Additional_Customer");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasKey(e => e.AuditIncId)
                    .HasName("Audit_Inc_ID");

                entity.ToTable("Audit_Log");

                entity.Property(e => e.AuditIncId).HasColumnName("Audit_Inc_ID");

                entity.Property(e => e.AuditAccNo)
                    .HasMaxLength(64)
                    .HasColumnName("Audit_Acc_No");

                entity.Property(e => e.AuditBranch)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_Branch");

                entity.Property(e => e.AuditComment)
                    .HasMaxLength(1000)
                    .HasColumnName("Audit_Comment");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Audit_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AuditLocation)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_Location");

                entity.Property(e => e.AuditModule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Audit_Module");

                entity.Property(e => e.AuditPatId)
                    .HasMaxLength(64)
                    .HasColumnName("Audit_Pat_ID");

                entity.Property(e => e.AuditPatName)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_Pat_Name");

                entity.Property(e => e.AuditProcName)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_Proc_Name");

                entity.Property(e => e.AuditStudyId).HasColumnName("Audit_Study_ID");

                entity.Property(e => e.AuditType)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_Type");

                entity.Property(e => e.AuditUserCategory).HasColumnName("Audit_User_Category");

                entity.Property(e => e.AuditUserName)
                    .HasMaxLength(50)
                    .HasColumnName("Audit_User_Name");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.BranchCode);

                entity.ToTable("branch");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(255)
                    .HasColumnName("branch_address");

                entity.Property(e => e.BranchLogo)
                    .HasColumnType("image")
                    .HasColumnName("Branch_Logo");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("branch_name");

                entity.Property(e => e.BranchPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branch_phone");

                entity.Property(e => e.CarePassportGuid)
                    .HasMaxLength(50)
                    .HasColumnName("CarePassport_GUID");

                entity.Property(e => e.CareRadUrl)
                    .HasMaxLength(255)
                    .HasColumnName("CareRad_URL");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_ID")
                    .HasDefaultValueSql("((183))");

                entity.Property(e => e.CustId).HasColumnName("Cust_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customer_name");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FooterName)
                    .HasMaxLength(255)
                    .HasColumnName("footer_name");

                entity.Property(e => e.FtpIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ftp_IP");

                entity.Property(e => e.FtpPassive)
                    .HasColumnName("Ftp_Passive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FtpUserName)
                    .HasMaxLength(50)
                    .HasColumnName("Ftp_User_Name");

                entity.Property(e => e.FtpUserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ftp_User_Password");

                entity.Property(e => e.HeaderName)
                    .HasMaxLength(255)
                    .HasColumnName("header_name");

                entity.Property(e => e.ImportDir)
                    .HasMaxLength(255)
                    .HasColumnName("Import_Dir");

                entity.Property(e => e.MiReportUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MiReport_URL");

                entity.Property(e => e.MiRisUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MiRIS_URL");

                entity.Property(e => e.PacsAe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PACS_AE");

                entity.Property(e => e.PacsIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PACS_IP");

                entity.Property(e => e.PacsPort).HasColumnName("PACS_Port");

                entity.Property(e => e.PatientsDir)
                    .HasMaxLength(255)
                    .HasColumnName("Patients_Dir");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Postal_Code");

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("Receipt_No")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReceiptNoOther)
                    .HasColumnName("Receipt_No_Other")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SenderAet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sender_AET");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Server_IP");

                entity.Property(e => e.ServerSqlName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Server_Sql_Name");

                entity.Property(e => e.ServerSqlUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Server_Sql_User_Name");

                entity.Property(e => e.ServerSqlUserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Server_Sql_User_Password");

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(100)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.StreamingUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Streaming_URL");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZone_ID");

                entity.Property(e => e.UsersProfileDirectory)
                    .HasMaxLength(255)
                    .HasColumnName("Users_Profile_Directory");

                entity.Property(e => e.UsersTemplates)
                    .HasMaxLength(255)
                    .HasColumnName("Users_Templates");

                entity.Property(e => e.WebSite).HasMaxLength(100);

                entity.Property(e => e.WebViewUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("WebView_URL");
            });

            modelBuilder.Entity<CathDiag>(entity =>
            {
                entity.HasKey(e => e.DiagIncId);

                entity.ToTable("Cath_Diag");

                entity.Property(e => e.DiagIncId).HasColumnName("Diag_Inc_ID");

                entity.Property(e => e.DiagBifurcationLesion)
                    .HasColumnName("Diag_Bifurcation_Lesion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchAssessed)
                    .HasColumnName("Diag_Branch_Assessed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchDenovoIsr)
                    .HasColumnName("Diag_Branch_Denovo_ISR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchGraftAccessed)
                    .HasColumnName("Diag_Branch_Graft_Accessed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchGraftArteryVien)
                    .HasColumnName("Diag_Branch_Graft_Artery_Vien")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchGraftDenovoIsr)
                    .HasColumnName("Diag_Branch_Graft_Denovo_ISR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchGraftLocationLesion)
                    .HasColumnName("Diag_Branch_Graft_Location_Lesion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchGraftStenosis)
                    .HasColumnName("Diag_Branch_Graft_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagBranchStenosis)
                    .HasColumnName("Diag_Branch_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagCathDet).HasColumnName("Diag_Cath_Det");

                entity.Property(e => e.DiagLargeThrombous)
                    .HasColumnName("Diag_Large_Thrombous")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagLesionExtemeAngulation)
                    .HasColumnName("Diag_Lesion_Exteme_Angulation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagPreProcTimiFlow)
                    .HasColumnName("Diag_Pre_Proc_TIMI_Flow")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiagPrevDilatationMethod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Diag_Prev_Dilatation_Method");

                entity.Property(e => e.DiagSegNumber)
                    .HasColumnName("Diag_Seg_Number")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DiagCathDetNavigation)
                    .WithMany(p => p.CathDiags)
                    .HasForeignKey(d => d.DiagCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_Diag_Cath_Det");
            });

            modelBuilder.Entity<CathHist>(entity =>
            {
                entity.HasKey(e => e.HistIncId);

                entity.ToTable("Cath_Hist");

                entity.Property(e => e.HistIncId).HasColumnName("Hist_Inc_ID");

                entity.Property(e => e.His1)
                    .HasColumnName("his_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His10)
                    .HasColumnName("his_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His11)
                    .HasColumnName("his_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His2)
                    .HasColumnName("his_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His4)
                    .HasColumnName("his_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His5)
                    .HasColumnName("his_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His6)
                    .HasColumnName("his_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His7)
                    .HasColumnName("his_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His8)
                    .HasColumnName("his_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.His9)
                    .HasColumnName("his_9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistAcsTimePeriod)
                    .HasColumnName("Hist_ACS_Time_Period")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistAngina)
                    .HasColumnName("Hist_Angina")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistCardioShock)
                    .HasColumnName("Hist_Cardio_Shock")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistCathDet).HasColumnName("Hist_Cath_Det");

                entity.Property(e => e.HistChf)
                    .HasColumnName("Hist_CHF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistNonInvTestInchemia)
                    .HasColumnName("Hist_Non_Inv_Test_Inchemia")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HistPerviousCabg)
                    .HasColumnType("datetime")
                    .HasColumnName("Hist_Pervious_CABG");

                entity.Property(e => e.HistPerviousPci)
                    .HasColumnType("datetime")
                    .HasColumnName("Hist_Pervious_PCI");

                entity.Property(e => e.HistPerviousValveSurgery)
                    .HasColumnType("datetime")
                    .HasColumnName("Hist_Pervious_Valve_Surgery");

                entity.HasOne(d => d.HistCathDetNavigation)
                    .WithMany(p => p.CathHists)
                    .HasForeignKey(d => d.HistCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_Hist_Cath_Det");
            });

            modelBuilder.Entity<CathInCathComp>(entity =>
            {
                entity.HasKey(e => e.InCathIncId);

                entity.ToTable("Cath_InCath_Comp");

                entity.Property(e => e.InCathIncId).HasColumnName("InCath_Inc_ID");

                entity.Property(e => e.InCathCategory).HasColumnName("InCath_Category");

                entity.Property(e => e.InCathCathDet).HasColumnName("InCath_Cath_Det");

                entity.Property(e => e.InCathGen1)
                    .HasColumnName("InCathGen_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen10)
                    .HasColumnName("InCathGen_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen11)
                    .HasColumnName("InCathGen_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen12)
                    .HasColumnName("InCathGen_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen2)
                    .HasColumnName("InCathGen_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen3)
                    .HasColumnName("InCathGen_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen4)
                    .HasColumnName("InCathGen_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen5)
                    .HasColumnName("InCathGen_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen6)
                    .HasColumnName("InCathGen_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen7)
                    .HasColumnName("InCathGen_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen8)
                    .HasColumnName("InCathGen_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathGen9)
                    .HasColumnName("InCathGen_9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas1)
                    .HasColumnName("InCathVas_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas10)
                    .HasColumnName("InCathVas_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas11)
                    .HasColumnName("InCathVas_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas12)
                    .HasColumnName("InCathVas_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas2)
                    .HasColumnName("InCathVas_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas3)
                    .HasColumnName("InCathVas_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas4)
                    .HasColumnName("InCathVas_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas5)
                    .HasColumnName("InCathVas_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas6)
                    .HasColumnName("InCathVas_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas7)
                    .HasColumnName("InCathVas_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas8)
                    .HasColumnName("InCathVas_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InCathVas9)
                    .HasColumnName("InCathVas_9")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.InCathCathDetNavigation)
                    .WithMany(p => p.CathInCathComps)
                    .HasForeignKey(d => d.InCathCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_In_Cath_Cath_Det");
            });

            modelBuilder.Entity<CathItem>(entity =>
            {
                entity.HasKey(e => e.ItemIncId);

                entity.ToTable("Cath_Item");

                entity.Property(e => e.ItemIncId).HasColumnName("Item_Inc_ID");

                entity.Property(e => e.ItemCategory)
                    .HasColumnName("Item_Category")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemFieldDefaultIndex)
                    .HasColumnName("Item_Field_Default_Index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemFieldDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Item_Field_Desc");

                entity.Property(e => e.ItemFieldName)
                    .HasMaxLength(50)
                    .HasColumnName("Item_Field_Name");

                entity.Property(e => e.ItemFieldType)
                    .HasColumnName("Item_Field_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemIndex)
                    .HasColumnName("Item_Index")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemModule).HasColumnName("Item_Module");
            });

            modelBuilder.Entity<CathItemValue>(entity =>
            {
                entity.HasKey(e => e.ItemsValuesIncId);

                entity.ToTable("Cath_Item_Value");

                entity.Property(e => e.ItemsValuesIncId).HasColumnName("Items_Values_Inc_ID");

                entity.Property(e => e.ItemsValuesDesc)
                    .HasMaxLength(255)
                    .HasColumnName("Items_Values_Desc");

                entity.Property(e => e.ItemsValuesItemDet)
                    .HasColumnName("Items_Values_Item_Det")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemsValuesItemName)
                    .HasMaxLength(50)
                    .HasColumnName("Items_Values_Item_Name");

                entity.Property(e => e.ItemsValuesValueName)
                    .HasColumnName("Items_Values_Value_Name")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ItemsValuesItemDetNavigation)
                    .WithMany(p => p.CathItemValues)
                    .HasForeignKey(d => d.ItemsValuesItemDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cath_Item_Value_Cath_Item");
            });

            modelBuilder.Entity<CathLabMed>(entity =>
            {
                entity.HasKey(e => e.LabMedIncId);

                entity.ToTable("Cath_Lab_Med");

                entity.Property(e => e.LabMedIncId).HasColumnName("Lab_Med_Inc_ID");

                entity.Property(e => e.Lab1)
                    .HasColumnName("lab_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab2)
                    .HasColumnName("lab_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab3)
                    .HasColumnName("lab_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab4)
                    .HasColumnName("lab_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab5)
                    .HasColumnName("lab_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab6)
                    .HasColumnName("lab_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lab7)
                    .HasColumnName("lab_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LabMedCathDet).HasColumnName("Lab_Med_Cath_Det");

                entity.HasOne(d => d.LabMedCathDetNavigation)
                    .WithMany(p => p.CathLabMeds)
                    .HasForeignKey(d => d.LabMedCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_Lab_Med_Cath_Det");
            });

            modelBuilder.Entity<CathMed>(entity =>
            {
                entity.HasKey(e => e.MedIncId);

                entity.ToTable("Cath_Med");

                entity.Property(e => e.MedIncId).HasColumnName("Med_Inc_ID");

                entity.Property(e => e.Med1)
                    .HasColumnName("med_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med10)
                    .HasColumnName("med_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med11)
                    .HasColumnName("med_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med12)
                    .HasColumnName("med_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med13)
                    .HasColumnName("med_13")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med14)
                    .HasColumnName("med_14")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med15)
                    .HasColumnName("med_15")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med2)
                    .HasColumnName("med_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med3)
                    .HasColumnName("med_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med4)
                    .HasColumnName("med_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med5)
                    .HasColumnName("med_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med6)
                    .HasColumnName("med_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med7)
                    .HasColumnName("med_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med8)
                    .HasColumnName("med_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Med9)
                    .HasColumnName("med_9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MedCathDet).HasColumnName("Med_Cath_Det");

                entity.HasOne(d => d.MedCathDetNavigation)
                    .WithMany(p => p.CathMeds)
                    .HasForeignKey(d => d.MedCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_Med_Cath_Det");
            });

            modelBuilder.Entity<CathPci>(entity =>
            {
                entity.HasKey(e => e.PciIncId);

                entity.ToTable("Cath_PCI");

                entity.Property(e => e.PciIncId).HasColumnName("PCI_Inc_ID");

                entity.Property(e => e.PciAcuteClosure)
                    .HasColumnName("PCI_Acute_Closure")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciAcuteClosureSuccessfulReopening)
                    .HasColumnName("PCI_Acute_Closure_Successful_Reopening")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciBallonPreDilatation)
                    .HasColumnName("PCI_Ballon_Pre_Dilatation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciCathDet).HasColumnName("PCI_Cath_Det");

                entity.Property(e => e.PciDissection)
                    .HasColumnName("PCI_Dissection")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciGuidingCathLength)
                    .HasColumnName("PCI_Guiding_Cath_Length")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciGuidingWireFloppyNumber)
                    .HasColumnName("PCI_Guiding_Wire_FLoppy_Number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciGuidingWireFloppyTradeName)
                    .HasMaxLength(50)
                    .HasColumnName("PCI_Guiding_Wire_FLoppy_TradeName");

                entity.Property(e => e.PciGuidingWireIntermediateNumber)
                    .HasColumnName("PCI_Guiding_Wire_Intermediate_Number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciGuidingWireIntermediateTradeName)
                    .HasMaxLength(50)
                    .HasColumnName("PCI_Guiding_Wire_Intermediate_TradeName");

                entity.Property(e => e.PciGuidingWireStiffNumber).HasColumnName("PCI_Guiding_Wire_Stiff_Number");

                entity.Property(e => e.PciGuidingWireStiffTradeName)
                    .HasMaxLength(50)
                    .HasColumnName("PCI_Guiding_Wire_Stiff_TradeName");

                entity.Property(e => e.PciNoReflowPhenom)
                    .HasColumnName("PCI_No_Reflow_Phenom")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciPerforation)
                    .HasColumnName("PCI_Perforation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciPostProcStenosis)
                    .HasColumnName("PCI_Post_Proc_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciPostProcTimiFlow)
                    .HasColumnName("PCI_Post_Proc_TIMI_Flow")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciSegNumber)
                    .HasColumnName("PCI_Seg_Number")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciStentCount)
                    .HasColumnName("PCI_Stent_Count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PciType)
                    .HasColumnName("PCI_Type")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PciCathDetNavigation)
                    .WithMany(p => p.CathPcis)
                    .HasForeignKey(d => d.PciCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_PCI_Cath_Det");
            });

            modelBuilder.Entity<CathPciBalloon>(entity =>
            {
                entity.HasKey(e => e.BalloonPciInc);

                entity.ToTable("Cath_PCI_Balloon");

                entity.Property(e => e.BalloonPciInc).HasColumnName("Balloon_PCI_Inc");

                entity.Property(e => e.BalloonDiameter).HasColumnName("Balloon_Diameter");

                entity.Property(e => e.BalloonInflaPressure).HasColumnName("Balloon_Infla_Pressure");

                entity.Property(e => e.BalloonInflaTime)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("Balloon_Infla_time");

                entity.Property(e => e.BalloonLength).HasColumnName("Balloon_Length");

                entity.Property(e => e.BalloonPciDet).HasColumnName("Balloon_PCI_Det");

                entity.Property(e => e.BalloonType)
                    .HasMaxLength(50)
                    .HasColumnName("Balloon_Type");

                entity.HasOne(d => d.BalloonPciDetNavigation)
                    .WithMany(p => p.CathPciBalloons)
                    .HasForeignKey(d => d.BalloonPciDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cath_PCI_Balloon_Cath_PCI");
            });

            modelBuilder.Entity<CathPciStent>(entity =>
            {
                entity.HasKey(e => e.StentPciInc);

                entity.ToTable("Cath_PCI_Stents");

                entity.Property(e => e.StentPciInc).HasColumnName("Stent_PCI_Inc");

                entity.Property(e => e.StentCathDet).HasColumnName("Stent_Cath_Det");

                entity.Property(e => e.StentDiameter)
                    .HasColumnName("Stent_Diameter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StentInflationPressure)
                    .HasColumnName("Stent_Inflation_Pressure")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StentLength)
                    .HasColumnName("Stent_Length")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StentManufacturer)
                    .HasMaxLength(50)
                    .HasColumnName("Stent_Manufacturer");

                entity.Property(e => e.StentPciDet).HasColumnName("Stent_PCI_Det");

                entity.Property(e => e.StentType)
                    .HasMaxLength(15)
                    .HasColumnName("Stent_Type");

                entity.HasOne(d => d.StentPciDetNavigation)
                    .WithMany(p => p.CathPciStents)
                    .HasForeignKey(d => d.StentPciDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cath_PCI_Stents_Cath_PCI");
            });

            modelBuilder.Entity<CathPostCathComp>(entity =>
            {
                entity.HasKey(e => e.PostCathIncId);

                entity.ToTable("Cath_PostCath_Comp");

                entity.Property(e => e.PostCathIncId).HasColumnName("PostCath_Inc_ID");

                entity.Property(e => e.PostCathCategory).HasColumnName("PostCath_Category");

                entity.Property(e => e.PostCathCathDet).HasColumnName("PostCath_Cath_Det");

                entity.Property(e => e.PostCathGen1)
                    .HasColumnName("PostCathGen_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen10)
                    .HasColumnName("PostCathGen_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen11)
                    .HasColumnName("PostCathGen_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen12)
                    .HasColumnName("PostCathGen_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen2)
                    .HasColumnName("PostCathGen_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen3)
                    .HasColumnName("PostCathGen_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen4)
                    .HasColumnName("PostCathGen_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen5)
                    .HasColumnName("PostCathGen_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen6)
                    .HasColumnName("PostCathGen_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen7)
                    .HasColumnName("PostCathGen_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen8)
                    .HasColumnName("PostCathGen_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathGen9)
                    .HasColumnName("PostCathGen_9")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas1)
                    .HasColumnName("PostCathVas_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas10)
                    .HasColumnName("PostCathVas_10")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas11)
                    .HasColumnName("PostCathVas_11")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas12)
                    .HasColumnName("PostCathVas_12")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas2)
                    .HasColumnName("PostCathVas_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas3)
                    .HasColumnName("PostCathVas_3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas4)
                    .HasColumnName("PostCathVas_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas5)
                    .HasColumnName("PostCathVas_5")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas6)
                    .HasColumnName("PostCathVas_6")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas7)
                    .HasColumnName("PostCathVas_7")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas8)
                    .HasColumnName("PostCathVas_8")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PostCathVas9)
                    .HasColumnName("PostCathVas_9")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PostCathCathDetNavigation)
                    .WithMany(p => p.CathPostCathComps)
                    .HasForeignKey(d => d.PostCathCathDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Cath_Inc_ID_PostCath_Cath_Det");
            });

            modelBuilder.Entity<CathSr>(entity =>
            {
                entity.HasKey(e => e.CathIncId);

                entity.ToTable("Cath_SR");

                entity.Property(e => e.CathIncId).HasColumnName("Cath_Inc_ID");

                entity.Property(e => e.CathCompSummary).HasColumnName("Cath_Comp_Summary");

                entity.Property(e => e.CathDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Cath_DateTime");

                entity.Property(e => e.CathDeathDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cath_Death_Date");

                entity.Property(e => e.CathDeathPrimaryCauseOfDeath)
                    .HasColumnName("Cath_Death_Primary_Cause_of_Death")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDeathTime)
                    .HasColumnName("Cath_Death_Time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAorticAoSbp)
                    .HasColumnName("Cath_Diag_Aortic_AO_SBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAorticInsufficiency)
                    .HasColumnName("Cath_Diag_Aortic_Insufficiency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAorticLvSbp)
                    .HasColumnName("Cath_Diag_Aortic_LV_SBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAorticPg)
                    .HasColumnName("Cath_Diag_Aortic_PG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAorticStenosis)
                    .HasColumnName("Cath_Diag_Aortic_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagAssistantName)
                    .HasMaxLength(50)
                    .HasColumnName("Cath_Diag_Assistant_Name");

                entity.Property(e => e.CathDiagEf)
                    .HasColumnName("Cath_Diag_EF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagEfObtainedBy)
                    .HasColumnName("Cath_Diag_EF_Obtained_By")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagIndications)
                    .HasColumnName("Cath_Diag_Indications")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagLvGram)
                    .HasColumnName("Cath_Diag_LV_Gram")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagMitralInsufficiency)
                    .HasColumnName("Cath_Diag_Mitral_Insufficiency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagMitralLvEdp)
                    .HasColumnName("Cath_Diag_Mitral_LV_EDP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagMitralMeanLa)
                    .HasColumnName("Cath_Diag_Mitral_Mean_LA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagMitralPg)
                    .HasColumnName("Cath_Diag_Mitral_PG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagMitralStenosis)
                    .HasColumnName("Cath_Diag_Mitral_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("Cath_Diag_Operator_Name");

                entity.Property(e => e.CathDiagPrecoutanousEntry)
                    .HasColumnName("Cath_Diag_Precoutanous_Entry")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cath_Diag_Proc_Date");

                entity.Property(e => e.CathDiagProcType)
                    .HasColumnName("Cath_Diag_Proc_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagPulmInsufficiency)
                    .HasColumnName("Cath_Diag_Pulm_Insufficiency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagPulmPaSbp)
                    .HasColumnName("Cath_Diag_Pulm_PA_SBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagPulmPg)
                    .HasColumnName("Cath_Diag_Pulm_PG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagPulmRvSbp)
                    .HasColumnName("Cath_Diag_Pulm_RV_SBP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagPulmStenosis)
                    .HasColumnName("Cath_Diag_Pulm_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagStatus)
                    .HasColumnName("Cath_Diag_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagSummary).HasColumnName("Cath_Diag_Summary");

                entity.Property(e => e.CathDiagTricuspidInsufficiency)
                    .HasColumnName("Cath_Diag_Tricuspid_Insufficiency")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagTricuspidMeanRa)
                    .HasColumnName("Cath_Diag_Tricuspid_Mean_RA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagTricuspidPg)
                    .HasColumnName("Cath_Diag_Tricuspid_PG")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagTricuspidRvEdp)
                    .HasColumnName("Cath_Diag_Tricuspid_RV_EDP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagTricuspidStenosis)
                    .HasColumnName("Cath_Diag_Tricuspid_Stenosis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDiagWallMotion)
                    .HasColumnName("Cath_Diag_Wall_Motion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathDischargeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cath_Discharge_Date");

                entity.Property(e => e.CathDischargeType)
                    .HasColumnName("Cath_Discharge_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathHistSummary).HasColumnName("Cath_Hist_Summary");

                entity.Property(e => e.CathMedSummary).HasColumnName("Cath_Med_Summary");

                entity.Property(e => e.CathPciAssistantName)
                    .HasMaxLength(50)
                    .HasColumnName("Cath_PCI_Assistant_Name");

                entity.Property(e => e.CathPciOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("Cath_PCI_Operator_Name");

                entity.Property(e => e.CathPciProcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cath_PCI_Proc_Date");

                entity.Property(e => e.CathPciStatus)
                    .HasColumnName("Cath_PCI_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPciSummary).HasColumnName("Cath_PCI_Summary");

                entity.Property(e => e.CathPreProcCkBaseline)
                    .HasColumnName("Cath_PreProc_CK_Baseline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPreProcCkMbBaseline)
                    .HasColumnName("Cath_PreProc_CK_MB_Baseline")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPreProcCkMbPeak)
                    .HasColumnName("Cath_PreProc_CK_MB_Peak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPreProcCkPeak)
                    .HasColumnName("Cath_PreProc_CK_Peak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPreProcMi)
                    .HasColumnName("Cath_PreProc_MI")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathPreProcNewQWaves)
                    .HasColumnName("Cath_PreProc_New_Q_Waves")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CathReportsDet).HasColumnName("Cath_Reports_Det");

                entity.Property(e => e.CathTreatmentSummary).HasColumnName("Cath_Treatment_Summary");

                entity.HasOne(d => d.CathReportsDetNavigation)
                    .WithMany(p => p.CathSrs)
                    .HasForeignKey(d => d.CathReportsDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("rep_inc_id_Cath_Reports_Det");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(100)
                    .HasColumnName("Country_Name");

                entity.Property(e => e.NationalityName)
                    .HasMaxLength(100)
                    .HasColumnName("Nationality_Name");
            });

            modelBuilder.Entity<Crnotification>(entity =>
            {
                entity.ToTable("CRNotifications");

                entity.Property(e => e.CrnotificationId).HasColumnName("CRNotification_ID");

                entity.Property(e => e.ActionId).HasColumnName("Action_ID");

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.HasNotified).HasDefaultValueSql("((0))");

                entity.Property(e => e.MdId).HasColumnName("MD_ID");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.NotificationDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverId).HasColumnName("Receiver_ID");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(50)
                    .HasColumnName("Receiver_Name");

                entity.Property(e => e.SenderId).HasColumnName("Sender_ID");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).HasColumnName("Cust_ID");

                entity.Property(e => e.Ccu)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CCU");
            });

            modelBuilder.Entity<DbComment>(entity =>
            {
                entity.HasKey(e => e.CommentIncId)
                    .HasName("Comment_Inc_ID");

                entity.ToTable("DB_Comments");

                entity.Property(e => e.CommentIncId).HasColumnName("Comment_Inc_ID");

                entity.Property(e => e.CommentTxt)
                    .HasMaxLength(50)
                    .HasColumnName("Comment_TXT");

                entity.Property(e => e.CommentType)
                    .HasColumnName("Comment_Type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Dic>(entity =>
            {
                entity.ToTable("dic");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DestName)
                    .HasMaxLength(50)
                    .HasColumnName("dest_name");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(50)
                    .HasColumnName("source_name");
            });

            modelBuilder.Entity<Echo>(entity =>
            {
                entity.HasKey(e => e.EIncId)
                    .HasName("E_Inc_ID");

                entity.ToTable("Echo");

                entity.Property(e => e.EIncId).HasColumnName("E_INC_ID");

                entity.Property(e => e.EAWave)
                    .HasMaxLength(50)
                    .HasColumnName("E_A_WAVE");

                entity.Property(e => e.EAoAsc)
                    .HasMaxLength(50)
                    .HasColumnName("E_AO_ASC");

                entity.Property(e => e.EAoRoot)
                    .HasMaxLength(50)
                    .HasColumnName("E_AO_ROOT");

                entity.Property(e => e.EAorticValve)
                    .HasMaxLength(255)
                    .HasColumnName("E_AORTIC_VALVE");

                entity.Property(e => e.EAtria)
                    .HasMaxLength(255)
                    .HasColumnName("E_ATRIA");

                entity.Property(e => e.EAvArGrade)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_AR_GRADE");

                entity.Property(e => e.EAvArPht)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_AR_PHT");

                entity.Property(e => e.EAvArea)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_AREA");

                entity.Property(e => e.EAvAsVti)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_AS_VTI");

                entity.Property(e => e.EAvCi)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_CI");

                entity.Property(e => e.EAvCo)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_CO");

                entity.Property(e => e.EAvLvotDiam)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_LVOT_DIAM");

                entity.Property(e => e.EAvLvotVel)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_LVOT_VEL");

                entity.Property(e => e.EAvLvotVti)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_LVOT_VTI");

                entity.Property(e => e.EAvMg)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_MG");

                entity.Property(e => e.EAvPg)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_PG");

                entity.Property(e => e.EAvSv)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_SV");

                entity.Property(e => e.EAvSysPv)
                    .HasMaxLength(50)
                    .HasColumnName("E_AV_SYS_PV");

                entity.Property(e => e.EBp1)
                    .HasColumnName("E_BP1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EBp2).HasColumnName("E_BP2");

                entity.Property(e => e.EBsa)
                    .HasColumnName("E_BSA")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EDate)
                    .HasColumnType("datetime")
                    .HasColumnName("E_DATE");

                entity.Property(e => e.EDisk)
                    .HasMaxLength(50)
                    .HasColumnName("E_DISK");

                entity.Property(e => e.EDt)
                    .HasMaxLength(50)
                    .HasColumnName("E_DT");

                entity.Property(e => e.EEA)
                    .HasMaxLength(50)
                    .HasColumnName("E_E_A");

                entity.Property(e => e.EEWave)
                    .HasMaxLength(50)
                    .HasColumnName("E_E_WAVE");

                entity.Property(e => e.EEf)
                    .HasColumnName("E_EF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EFs)
                    .HasColumnName("E_FS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EGreatVessels)
                    .HasMaxLength(255)
                    .HasColumnName("E_GREAT_VESSELS");

                entity.Property(e => e.EHr)
                    .HasColumnName("E_HR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EIvcCollapse)
                    .HasColumnName("E_IVC_COLLAPSE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EIvcDilated)
                    .HasColumnName("E_IVC_DILATED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EIvrt)
                    .HasMaxLength(50)
                    .HasColumnName("E_IVRT");

                entity.Property(e => e.EIvs)
                    .HasMaxLength(50)
                    .HasColumnName("E_IVS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ELa)
                    .HasMaxLength(50)
                    .HasColumnName("E_LA");

                entity.Property(e => e.ELa2d1).HasColumnName("E_LA_2D1");

                entity.Property(e => e.ELa2d2).HasColumnName("E_LA_2D2");

                entity.Property(e => e.ELvDiastolicFunction)
                    .HasMaxLength(255)
                    .HasColumnName("E_LV_DIASTOLIC_FUNCTION");

                entity.Property(e => e.ELvDimension)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("E_LV_DIMENSION");

                entity.Property(e => e.ELvSystolicFunction)
                    .HasMaxLength(255)
                    .HasColumnName("E_LV_SYSTOLIC_FUNCTION");

                entity.Property(e => e.ELvWallMotion)
                    .HasMaxLength(255)
                    .HasColumnName("E_LV_WALL_MOTION");

                entity.Property(e => e.ELvedd)
                    .HasColumnName("E_LVEDD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ELvedp)
                    .HasMaxLength(50)
                    .HasColumnName("E_LVEDP");

                entity.Property(e => e.ELvesd)
                    .HasColumnName("E_LVESD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EMaLat)
                    .HasMaxLength(50)
                    .HasColumnName("E_MA_LAT");

                entity.Property(e => e.EMaMed)
                    .HasMaxLength(50)
                    .HasColumnName("E_MA_MED");

                entity.Property(e => e.EManW)
                    .HasMaxLength(50)
                    .HasColumnName("E_MAN_W");

                entity.Property(e => e.EMass)
                    .HasColumnName("E_MASS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EMiaWidth)
                    .HasMaxLength(50)
                    .HasColumnName("E_MIA_WIDTH");

                entity.Property(e => e.EMitralValve)
                    .HasMaxLength(255)
                    .HasColumnName("E_MITRAL_VALVE");

                entity.Property(e => e.EMrap)
                    .HasMaxLength(50)
                    .HasColumnName("E_MRAP");

                entity.Property(e => e.EMvDpDt)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_DP_DT");

                entity.Property(e => e.EMvMg)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_MG");

                entity.Property(e => e.EMvMrGrade)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_MR_GRADE");

                entity.Property(e => e.EMvMva2d)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_MVA_2D");

                entity.Property(e => e.EMvMvaCe)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_MVA_CE");

                entity.Property(e => e.EMvMvaPht)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_MVA_PHT");

                entity.Property(e => e.EMvPg)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_PG");

                entity.Property(e => e.EMvPht)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_PHT");

                entity.Property(e => e.EMvVti)
                    .HasMaxLength(50)
                    .HasColumnName("E_MV_VTI");

                entity.Property(e => e.EOthers)
                    .HasMaxLength(255)
                    .HasColumnName("E_OTHERS");

                entity.Property(e => e.EPadp)
                    .HasMaxLength(50)
                    .HasColumnName("E_PADP");

                entity.Property(e => e.EPcwp)
                    .HasMaxLength(50)
                    .HasColumnName("E_PCWP");

                entity.Property(e => e.EPericardium)
                    .HasMaxLength(50)
                    .HasColumnName("E_PERICARDIUM");

                entity.Property(e => e.EPericardiumPleural)
                    .HasMaxLength(255)
                    .HasColumnName("E_PERICARDIUM_PLEURAL");

                entity.Property(e => e.EPleuralEffusion)
                    .HasColumnName("E_PLEURAL_EFFUSION")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EPulmonaryVeins)
                    .HasMaxLength(50)
                    .HasColumnName("E_PULMONARY_VEINS");

                entity.Property(e => e.EPulmonicValve)
                    .HasMaxLength(255)
                    .HasColumnName("E_PULMONIC_VALVE");

                entity.Property(e => e.EPvMg)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_MG");

                entity.Property(e => e.EPvPg)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_PG");

                entity.Property(e => e.EPvPrEdg)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_PR_EDG");

                entity.Property(e => e.EPvPrGrade)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_PR_GRADE");

                entity.Property(e => e.EPvRvotDiam)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_RVOT_DIAM");

                entity.Property(e => e.EPvRvotVel)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_RVOT_VEL");

                entity.Property(e => e.EPvSysPv)
                    .HasMaxLength(50)
                    .HasColumnName("E_PV_SYS_PV");

                entity.Property(e => e.EPvaWidth)
                    .HasMaxLength(50)
                    .HasColumnName("E_PVA_WIDTH");

                entity.Property(e => e.EPw)
                    .HasMaxLength(50)
                    .HasColumnName("E_PW");

                entity.Property(e => e.EQpQs)
                    .HasMaxLength(50)
                    .HasColumnName("E_QP_QS");

                entity.Property(e => e.ERa2d1)
                    .HasColumnName("E_RA_2D1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ERa2d2)
                    .HasColumnName("E_RA_2D2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ERepIncDet).HasColumnName("E_REP_INC_DET");

                entity.Property(e => e.ERightVentricle)
                    .HasMaxLength(255)
                    .HasColumnName("E_RIGHT_VENTRICLE");

                entity.Property(e => e.ERv)
                    .HasMaxLength(50)
                    .HasColumnName("E_RV");

                entity.Property(e => e.ERv2d)
                    .HasMaxLength(50)
                    .HasColumnName("E_RV_2D");

                entity.Property(e => e.ERvsp)
                    .HasMaxLength(50)
                    .HasColumnName("E_RVSP");

                entity.Property(e => e.ESD)
                    .HasMaxLength(50)
                    .HasColumnName("E_S_D");

                entity.Property(e => e.EShunts)
                    .HasMaxLength(255)
                    .HasColumnName("E_SHUNTS");

                entity.Property(e => e.ETaLat)
                    .HasMaxLength(50)
                    .HasColumnName("E_TA_LAT");

                entity.Property(e => e.ETanW)
                    .HasMaxLength(50)
                    .HasColumnName("E_TAN_W");

                entity.Property(e => e.ETape)
                    .HasMaxLength(50)
                    .HasColumnName("E_TAPE");

                entity.Property(e => e.ETdiE)
                    .HasMaxLength(50)
                    .HasColumnName("E_TDI_E");

                entity.Property(e => e.ETdiEA)
                    .HasMaxLength(50)
                    .HasColumnName("E_TDI_E_A");

                entity.Property(e => e.ETricuspidValve)
                    .HasMaxLength(255)
                    .HasColumnName("E_TRICUSPID_VALVE");

                entity.Property(e => e.ETvMg)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_MG");

                entity.Property(e => e.ETvPg)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_PG");

                entity.Property(e => e.ETvPht)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_PHT");

                entity.Property(e => e.ETvTrGrade)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_TR_GRADE");

                entity.Property(e => e.ETvTrPg)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_TR_PG");

                entity.Property(e => e.ETvTvaCe)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_TVA_CE");

                entity.Property(e => e.ETvTvaPht)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_TVA_PHT");

                entity.Property(e => e.ETvVti)
                    .HasMaxLength(50)
                    .HasColumnName("E_TV_VTI");

                entity.Property(e => e.EValsalvaEA)
                    .HasMaxLength(50)
                    .HasColumnName("E_VALSALVA_E_A");
            });

            modelBuilder.Entity<EdDiscrepancy>(entity =>
            {
                entity.HasKey(e => e.DiscIncId);

                entity.ToTable("ED_Discrepancy");

                entity.Property(e => e.DiscIncId).HasColumnName("Disc_Inc_ID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DiscScore)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Disc_Score");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Review_Date");

                entity.Property(e => e.ReviewerType).HasColumnName("Reviewer_Type");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<FindingCategory>(entity =>
            {
                entity.HasKey(e => e.FindCategoryIncId)
                    .HasName("Find_Category_Inc_ID");

                entity.ToTable("Finding_Category");

                entity.Property(e => e.FindCategoryIncId).HasColumnName("Find_Category_Inc_ID");

                entity.Property(e => e.FindCategoryDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Find_Category_Desc");
            });

            modelBuilder.Entity<FindingDesc>(entity =>
            {
                entity.HasKey(e => e.FindIncId)
                    .HasName("Find_Inc_ID");

                entity.ToTable("Finding_Desc");

                entity.Property(e => e.FindIncId).HasColumnName("Find_Inc_ID");

                entity.Property(e => e.FindDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Find_Desc");
            });

            modelBuilder.Entity<FindingSystem>(entity =>
            {
                entity.HasKey(e => e.FindSystemIncId)
                    .HasName("Find_System_Inc_ID");

                entity.ToTable("Finding_Systems");

                entity.Property(e => e.FindSystemIncId).HasColumnName("Find_System_Inc_ID");

                entity.Property(e => e.FindSystemDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Find_System_Desc");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.GroupIncId);

                entity.ToTable("Group");

                entity.Property(e => e.GroupIncId).HasColumnName("Group_Inc_ID");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasColumnName("Group_Code");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .HasColumnName("Group_Name");

                entity.Property(e => e.GroupPermissions)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Group_Permissions");
            });

            modelBuilder.Entity<InstInfo>(entity =>
            {
                entity.HasKey(e => e.InstIncId)
                    .HasName("Inst_inc_id");

                entity.ToTable("InstInfo");

                entity.Property(e => e.InstIncId).HasColumnName("Inst_inc_id");

                entity.Property(e => e.AcquisTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BitsAllocated).HasDefaultValueSql("((0))");

                entity.Property(e => e.BitsStored).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConvKernel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Conv_Kernel");

                entity.Property(e => e.FrameRefUid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Frame_Ref_UID");

                entity.Property(e => e.HighBit).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageLaterality)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageOrient)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePos)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstFileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.InstPatId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Inst_Pat_ID");

                entity.Property(e => e.InstSeriesUid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Inst_SeriesUID");

                entity.Property(e => e.InstStudyIncIdDet)
                    .HasColumnName("Inst_Study_Inc_ID_det")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstStudyUid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Inst_StudyUID");

                entity.Property(e => e.InstType)
                    .HasColumnName("Inst_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InstUid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("InstUID");

                entity.Property(e => e.KnCodeMeaning)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KN_Code_Meaning");

                entity.Property(e => e.KnCodeValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KN_Code_Value");

                entity.Property(e => e.KnCodingSchemeDesi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KN_Coding_Scheme_Desi");

                entity.Property(e => e.LossyComp).HasDefaultValueSql("((0))");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturersModelName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Modality_Name");

                entity.Property(e => e.NoCloumns)
                    .HasColumnName("No_Cloumns")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoFrames)
                    .HasColumnName("No_Frames")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NoRows)
                    .HasColumnName("No_Rows")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ObservationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Observation_Date");

                entity.Property(e => e.Photometric).HasDefaultValueSql("((0))");

                entity.Property(e => e.PixelAspectRatio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PixelRepresent).HasDefaultValueSql("((0))");

                entity.Property(e => e.PixelSpace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrCreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PR_Creation_Date");

                entity.Property(e => e.PrCreatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PR_Creator_Name");

                entity.Property(e => e.PrDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PR_Desc");

                entity.Property(e => e.PrLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PR_Label");

                entity.Property(e => e.SeriesDir)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Series_Dir");

                entity.Property(e => e.SeriesIncIdDet)
                    .HasColumnName("Series_Inc_ID_Det")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SliceLoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.SliceThick).HasDefaultValueSql("((0))");

                entity.Property(e => e.SopclassUid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SOPClassUID");

                entity.Property(e => e.TransSyntax)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Trans_Syntax");

                entity.Property(e => e.ViewPosition)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.SeriesIncIdDetNavigation)
                    .WithMany(p => p.InstInfos)
                    .HasForeignKey(d => d.SeriesIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Series_Inc_ID_Series_Inc_ID_Det_InstInfo");
            });

            modelBuilder.Entity<Integration>(entity =>
            {
                entity.HasKey(e => e.IntegrationIncId);

                entity.ToTable("Integration");

                entity.Property(e => e.IntegrationIncId).HasColumnName("Integration_Inc_Id");

                entity.Property(e => e.BranchCode).HasColumnName("Branch_Code");

                entity.Property(e => e.Url)
                    .HasMaxLength(2000)
                    .HasColumnName("URL");

                entity.Property(e => e.UrlDescription)
                    .HasMaxLength(256)
                    .HasColumnName("URL_Description");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.Integrations)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Integration_branch");
            });

            modelBuilder.Entity<JobOrder>(entity =>
            {
                entity.HasKey(e => e.AccessionNoInc)
                    .HasName("AccessionNo_Inc");

                entity.ToTable("job_orders");

                entity.Property(e => e.AccessionNoInc).HasColumnName("AccessionNo_Inc");

                entity.Property(e => e.AccessionNoStr)
                    .HasMaxLength(64)
                    .HasColumnName("AccessionNo_Str");

                entity.Property(e => e.EmergencyOrder)
                    .HasColumnName("emergency_order")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdComment)
                    .HasMaxLength(100)
                    .HasColumnName("ord_comment");

                entity.Property(e => e.OrdDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("Ord_datetime");

                entity.Property(e => e.OrdPatId)
                    .HasMaxLength(64)
                    .HasColumnName("Ord_Pat_ID");

                entity.Property(e => e.OrdPatIncIdDet).HasColumnName("Ord_Pat_Inc_ID_Det");

                entity.Property(e => e.OrdPatName)
                    .HasMaxLength(50)
                    .HasColumnName("Ord_Pat_Name");

                entity.Property(e => e.OrdPrintingStatus).HasColumnName("Ord_Printing_Status");

                entity.Property(e => e.OrdReceptionist)
                    .HasMaxLength(50)
                    .HasColumnName("Ord_Receptionist");

                entity.HasOne(d => d.OrdPatIncIdDetNavigation)
                    .WithMany(p => p.JobOrders)
                    .HasForeignKey(d => d.OrdPatIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Pat_Inc_ID_Ord_Pat_Inc_ID_Det");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.LanguageId).HasColumnName("Language_ID");

                entity.Property(e => e.LanguageAbbreviation)
                    .HasMaxLength(4)
                    .HasColumnName("Language_Abbreviation");

                entity.Property(e => e.LanguageDirection)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Language_Direction");

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(50)
                    .HasColumnName("Language_Name");
            });

            modelBuilder.Entity<LanguageCustomer>(entity =>
            {
                entity.HasKey(e => e.LangInc);

                entity.ToTable("Language_Customer");

                entity.Property(e => e.LangInc).HasColumnName("lang_inc");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.LanguageAbbreviation)
                    .HasMaxLength(4)
                    .HasColumnName("Language_abbreviation");

                entity.Property(e => e.LanguageFilePath).HasMaxLength(50);

                entity.Property(e => e.UserlangId).HasColumnName("Userlang_ID");
            });

            modelBuilder.Entity<LifeCycleManager>(entity =>
            {
                entity.HasKey(e => e.LifecycleIncId);

                entity.ToTable("LifeCycle_Manager");

                entity.Property(e => e.LifecycleIncId).HasColumnName("Lifecycle_Inc_ID");

                entity.Property(e => e.AccessionNo).HasMaxLength(64);

                entity.Property(e => e.ActionDateTime).HasColumnName("Action_DateTime");

                entity.Property(e => e.ActionId).HasColumnName("Action_ID");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.DestinationDirectory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Destination_Directory");

                entity.Property(e => e.Modality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatId)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_ID");

                entity.Property(e => e.PatName)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_Name");

                entity.Property(e => e.RemotePacs)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Remote_PACS");

                entity.Property(e => e.StudyId)
                    .HasMaxLength(16)
                    .HasColumnName("Study_ID");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.MachineCode);

                entity.ToTable("machines");

                entity.Property(e => e.MachineCode).HasColumnName("machine_code");

                entity.Property(e => e.AeTitle)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ae_title");

                entity.Property(e => e.BranchCode).HasColumnName("Branch_Code");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.LocalMachine)
                    .HasColumnName("Local_Machine")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineIpAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("machine_ip_address");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .HasColumnName("machine_name");

                entity.Property(e => e.MachinePortNumber).HasColumnName("machine_port_number");

                entity.Property(e => e.MachineRestriction)
                    .HasColumnName("Machine_Restriction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineRestrictionComment)
                    .HasMaxLength(500)
                    .HasColumnName("Machine_Restriction_Comment");

                entity.Property(e => e.MachineRestrictionFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("Machine_Restriction_From");

                entity.Property(e => e.MachineRestrictionTo)
                    .HasColumnType("datetime")
                    .HasColumnName("Machine_Restriction_To");

                entity.Property(e => e.MachineUseWl)
                    .HasColumnName("Machine_Use_WL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Modality_Name");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("Room_Name");
            });

            modelBuilder.Entity<MachineProc>(entity =>
            {
                entity.HasKey(e => e.MachineProcInc)
                    .HasName("Pk_Machine_Proc_inc");

                entity.ToTable("Machine_Proc");

                entity.Property(e => e.MachineProcInc).HasColumnName("Machine_Proc_inc");

                entity.Property(e => e.MachineCode).HasColumnName("Machine_Code");

                entity.Property(e => e.ProcCode).HasColumnName("Proc_Code");
            });

            modelBuilder.Entity<MammoFollowUp>(entity =>
            {
                entity.HasKey(e => e.FollowUpIncId);

                entity.ToTable("Mammo_FollowUp");

                entity.Property(e => e.FollowUpIncId).HasColumnName("FollowUp_Inc_ID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpStatus).HasColumnName("FollowUp_Status");

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.HasOne(d => d.StudyInc)
                    .WithMany(p => p.MammoFollowUps)
                    .HasForeignKey(d => d.StudyIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mammo_FollowUp_Studies");
            });

            modelBuilder.Entity<MammoFollowUpAction>(entity =>
            {
                entity.HasKey(e => e.ActionIncId);

                entity.ToTable("Mammo_FollowUp_Actions");

                entity.Property(e => e.ActionIncId).HasColumnName("Action_Inc_ID");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Action_Date");

                entity.Property(e => e.ActionId).HasColumnName("Action_ID");

                entity.Property(e => e.ActionTypeId).HasColumnName("ActionType_ID");

                entity.Property(e => e.FollowUpIncId).HasColumnName("FollowUp_Inc_ID");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.HasOne(d => d.FollowUpInc)
                    .WithMany(p => p.MammoFollowUpActions)
                    .HasForeignKey(d => d.FollowUpIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mammo_FollowUp_Actions_Mammo_FollowUp");
            });

            modelBuilder.Entity<MammoManagement>(entity =>
            {
                entity.HasKey(e => e.ManagementIncId)
                    .HasName("PK_Mammo_Managment");

                entity.ToTable("Mammo_Management");

                entity.Property(e => e.ManagementIncId).HasColumnName("Management_Inc_ID");

                entity.Property(e => e.BreastSide).HasColumnName("Breast_Side");

                entity.Property(e => e.FollowUpIncId).HasColumnName("FollowUp_Inc_ID");

                entity.HasOne(d => d.FollowUpInc)
                    .WithMany(p => p.MammoManagements)
                    .HasForeignKey(d => d.FollowUpIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mammo_Management_Mammo_FollowUp");
            });

            modelBuilder.Entity<MammoSFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackIncId);

                entity.ToTable("MammoS_Feedback");

                entity.Property(e => e.FeedbackIncId).HasColumnName("Feedback_Inc_ID");

                entity.Property(e => e.FinalDiagnostic).HasColumnName("Final_Diagnostic");

                entity.Property(e => e.LtBiopsyFeedback).HasColumnName("LT_Biopsy_Feedback");

                entity.Property(e => e.LtBiopsyNote)
                    .HasMaxLength(50)
                    .HasColumnName("LT_Biopsy_Note");

                entity.Property(e => e.LtMrFeedback).HasColumnName("LT_MR_Feedback");

                entity.Property(e => e.LtMrNote)
                    .HasMaxLength(50)
                    .HasColumnName("LT_MR_Note");

                entity.Property(e => e.LtOpFeedback).HasColumnName("LT_OP_Feedback");

                entity.Property(e => e.LtOpNote)
                    .HasMaxLength(50)
                    .HasColumnName("LT_OP_Note");

                entity.Property(e => e.LtUsFeedback).HasColumnName("LT_US_Feedback");

                entity.Property(e => e.LtUsNote)
                    .HasMaxLength(50)
                    .HasColumnName("LT_US_Note");

                entity.Property(e => e.PatCondition).HasColumnName("Pat_condition");

                entity.Property(e => e.RtBiopsyFeedback).HasColumnName("RT_Biopsy_Feedback");

                entity.Property(e => e.RtBiopsyNote)
                    .HasMaxLength(50)
                    .HasColumnName("RT_Biopsy_Note");

                entity.Property(e => e.RtMrFeedback).HasColumnName("RT_MR_Feedback");

                entity.Property(e => e.RtMrNote)
                    .HasMaxLength(50)
                    .HasColumnName("RT_MR_Note");

                entity.Property(e => e.RtOpFeedback).HasColumnName("RT_OP_Feedback");

                entity.Property(e => e.RtOpNote)
                    .HasMaxLength(50)
                    .HasColumnName("RT_OP_Note");

                entity.Property(e => e.RtUsFeedback).HasColumnName("RT_US_Feedback");

                entity.Property(e => e.RtUsNote)
                    .HasMaxLength(50)
                    .HasColumnName("RT_US_Note");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.HasOne(d => d.StudyInc)
                    .WithMany(p => p.MammoSFeedbacks)
                    .HasForeignKey(d => d.StudyIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MammoS_Feedback_MammoS_Feedback");
            });

            modelBuilder.Entity<MammoSLesion>(entity =>
            {
                entity.HasKey(e => e.LesionIncId)
                    .HasName("PK_Mammo_Lesions");

                entity.ToTable("MammoS_Lesions");

                entity.Property(e => e.LesionIncId).HasColumnName("Lesion_Inc_ID");

                entity.Property(e => e.BreastSide).HasColumnName("Breast_Side");

                entity.Property(e => e.CcX).HasColumnName("CC_X");

                entity.Property(e => e.CcY).HasColumnName("CC_Y");

                entity.Property(e => e.ImageView).HasColumnName("Image_View");

                entity.Property(e => e.MloX).HasColumnName("MLO_X");

                entity.Property(e => e.MloY).HasColumnName("MLO_Y");

                entity.Property(e => e.ReportIncId).HasColumnName("Report_Inc_ID");

                entity.HasOne(d => d.ReportInc)
                    .WithMany(p => p.MammoSLesions)
                    .HasForeignKey(d => d.ReportIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mammo_Lesions_Mammo_Reports");
            });

            modelBuilder.Entity<MammoSReport>(entity =>
            {
                entity.HasKey(e => e.ReportIncId)
                    .HasName("PK_Mammo_Report");

                entity.ToTable("MammoS_Reports");

                entity.Property(e => e.ReportIncId).HasColumnName("Report_Inc_ID");

                entity.Property(e => e.LtBirad).HasColumnName("LT_Birad");

                entity.Property(e => e.LtExpect).HasColumnName("LT_Expect");

                entity.Property(e => e.LtRecomm)
                    .HasMaxLength(50)
                    .HasColumnName("LT_Recomm");

                entity.Property(e => e.ReportDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Report_Date");

                entity.Property(e => e.ReportOrder).HasColumnName("Report_Order");

                entity.Property(e => e.RtBirad).HasColumnName("RT_Birad");

                entity.Property(e => e.RtExpect).HasColumnName("RT_Expect");

                entity.Property(e => e.RtRecomm)
                    .HasMaxLength(50)
                    .HasColumnName("RT_Recomm");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.TechnicalNote)
                    .HasMaxLength(50)
                    .HasColumnName("Technical_Note");

                entity.HasOne(d => d.StudyInc)
                    .WithMany(p => p.MammoSReports)
                    .HasForeignKey(d => d.StudyIncId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Mammo_Report_Studies");
            });

            modelBuilder.Entity<Md>(entity =>
            {
                entity.ToTable("MDS");

                entity.Property(e => e.Mdid).HasColumnName("MDID");

                entity.Property(e => e.Md0)
                    .HasMaxLength(500)
                    .HasColumnName("MD0");

                entity.Property(e => e.Md1)
                    .HasMaxLength(500)
                    .HasColumnName("MD1");

                entity.Property(e => e.Md2)
                    .HasMaxLength(500)
                    .HasColumnName("MD2");

                entity.Property(e => e.Md3)
                    .HasMaxLength(500)
                    .HasColumnName("MD3");

                entity.Property(e => e.Md4)
                    .HasMaxLength(500)
                    .HasColumnName("MD4");

                entity.Property(e => e.Md5)
                    .HasMaxLength(500)
                    .HasColumnName("MD5");
            });

            modelBuilder.Entity<Modality>(entity =>
            {
                entity.ToTable("modality");

                entity.Property(e => e.ModalityId).HasColumnName("modality_id");

                entity.Property(e => e.Modality1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Modality");

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Modality_Name");
            });

            modelBuilder.Entity<ModalityLocal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("modality_local");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.Modality)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modality");

                entity.Property(e => e.ModalityId).HasColumnName("modality_id");
            });

            modelBuilder.Entity<ModalityUser>(entity =>
            {
                entity.ToTable("Modality_users");

                entity.Property(e => e.ModalityUserId).HasColumnName("modality_user_id");

                entity.Property(e => e.Modality)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("modality");

                entity.Property(e => e.UName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_name");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.PatIncId)
                    .HasName("Pat_Inc_ID");

                entity.Property(e => e.PatIncId).HasColumnName("Pat_Inc_ID");

                entity.Property(e => e.PatAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_address");

                entity.Property(e => e.PatAddressOther)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_address_other");

                entity.Property(e => e.PatAgeFirstBaby)
                    .HasColumnName("Pat_Age_First_Baby")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatAgeMenarche)
                    .HasColumnName("Pat_Age_Menarche")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatAgeMenopause)
                    .HasColumnName("Pat_Age_Menopause")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatAllergies)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_allergies");

                entity.Property(e => e.PatBirthDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("Pat_birth_datetime");

                entity.Property(e => e.PatBreastSide)
                    .HasColumnName("Pat_Breast_Side")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatBreed)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Breed");

                entity.Property(e => e.PatCity)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_city");

                entity.Property(e => e.PatComment)
                    .HasMaxLength(255)
                    .HasColumnName("Pat_comment");

                entity.Property(e => e.PatContraceptive)
                    .HasColumnName("Pat_Contraceptive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatContraceptiveNo)
                    .HasColumnName("Pat_Contraceptive_No")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatCountry).HasColumnName("Pat_Country");

                entity.Property(e => e.PatDriverslicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_driverslicense_number");

                entity.Property(e => e.PatEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Email");

                entity.Property(e => e.PatEmailSec)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_Email_Sec");

                entity.Property(e => e.PatEmergContact)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_Emerg_contact");

                entity.Property(e => e.PatEmergPhone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Pat_Emerg_Phone");

                entity.Property(e => e.PatEthnicity).HasColumnName("Pat_Ethnicity");

                entity.Property(e => e.PatFamilyAgeDiscovery)
                    .HasColumnName("Pat_Family_Age_Discovery")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilyAunt)
                    .HasColumnName("Pat_Family_Aunt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilyHistory)
                    .HasColumnName("Pat_Family_History")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilyMother)
                    .HasColumnName("Pat_Family_Mother")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilyOther)
                    .HasColumnName("Pat_Family_Other")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilyOutcome)
                    .HasColumnName("Pat_Family_Outcome")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFamilySister)
                    .HasColumnName("Pat_Family_Sister")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatFirstvisitDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("Pat_firstvisit_datetime");

                entity.Property(e => e.PatHistory)
                    .HasMaxLength(4000)
                    .HasColumnName("Pat_History");

                entity.Property(e => e.PatId)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_ID");

                entity.Property(e => e.PatInsuranceNumber).HasColumnName("Pat_insurance_number");

                entity.Property(e => e.PatLactation)
                    .HasColumnName("Pat_Lactation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatMaritalStatus).HasColumnName("Pat_marital_status");

                entity.Property(e => e.PatName)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_Name");

                entity.Property(e => e.PatNameEnglish)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_name_english");

                entity.Property(e => e.PatNationality)
                    .HasMaxLength(30)
                    .HasColumnName("Pat_nationality");

                entity.Property(e => e.PatOutcome)
                    .HasColumnName("Pat_Outcome")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatPara)
                    .HasColumnName("Pat_Para")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatPhoneBusiness)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Pat_phone_business");

                entity.Property(e => e.PatPhoneCell)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Pat_phone_cell");

                entity.Property(e => e.PatPhoneHome)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Pat_phone_home");

                entity.Property(e => e.PatPrefix)
                    .HasMaxLength(30)
                    .HasColumnName("Pat_prefix");

                entity.Property(e => e.PatPrevBreastOperations)
                    .HasColumnName("Pat_Prev_Breast_Operations")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatRace).HasColumnName("Pat_Race");

                entity.Property(e => e.PatReligion).HasColumnName("Pat_religion");

                entity.Property(e => e.PatRespOrg)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Resp_Org");

                entity.Property(e => e.PatRespPerson)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Resp_Person");

                entity.Property(e => e.PatRespPersonRole)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Resp_PersonRole");

                entity.Property(e => e.PatSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Pat_sex")
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.PatSexNeutered)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Sex_Neutered");

                entity.Property(e => e.PatSpecies)
                    .HasMaxLength(64)
                    .HasColumnName("Pat_Species");

                entity.Property(e => e.PatSsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pat_SSN");

                entity.Property(e => e.PatState).HasColumnName("Pat_State");

                entity.Property(e => e.PatStudies)
                    .HasColumnName("Pat_Studies")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatVfc).HasColumnName("Pat_VFC");

                entity.Property(e => e.PatZipCode)
                    .HasMaxLength(50)
                    .HasColumnName("Pat_ZipCode");

                entity.Property(e => e.PrimaryLanguage).HasColumnName("Primary_Language");

                entity.Property(e => e.SecondaryLanguage).HasColumnName("Secondary_Language");

                entity.Property(e => e.UIdDet).HasColumnName("u_id_det");
            });

            modelBuilder.Entity<PeerReview>(entity =>
            {
                entity.HasKey(e => e.PeerReviewIncId);

                entity.ToTable("Peer Review");

                entity.Property(e => e.PeerReviewIncId).HasColumnName("PeerReview_IncID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CommitteeExtraScore)
                    .HasMaxLength(500)
                    .HasColumnName("Committee_ExtraScore");

                entity.Property(e => e.PeerReviewExtraScore)
                    .HasMaxLength(500)
                    .HasColumnName("PeerReview_ExtraScore");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Review_Date");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<PeerReviewConfig>(entity =>
            {
                entity.HasKey(e => e.RandomId);

                entity.ToTable("PeerReview_Config");

                entity.Property(e => e.RandomId).HasColumnName("Random_ID");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.MinimumNumberStudies).HasColumnName("MinimumNumber_Studies");

                entity.Property(e => e.Modality)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PeerReviewMemeberCount).HasColumnName("PeerReviewMemeber_Count");

                entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

                entity.Property(e => e.RandomPercentage)
                    .HasMaxLength(500)
                    .HasColumnName("Random_Percentage");

                entity.Property(e => e.User).HasMaxLength(500);
            });

            modelBuilder.Entity<PeerReviewPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodIncId);

                entity.ToTable("PeerReview_Period");

                entity.Property(e => e.PeriodIncId).HasColumnName("Period_Inc_ID");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.MinimumNumberStudies).HasColumnName("MinimumNumber_Studies");

                entity.Property(e => e.Modality).HasMaxLength(500);

                entity.Property(e => e.PeerReviewIsActive).HasColumnName("PeerReview_IsActive");

                entity.Property(e => e.PeerReviewMemeberCount).HasColumnName("PeerReviewMemeber_Count");

                entity.Property(e => e.PeriodEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Period_End");

                entity.Property(e => e.PeriodStart)
                    .HasColumnType("datetime")
                    .HasColumnName("Period_Start");

                entity.Property(e => e.RandomPercentage)
                    .HasMaxLength(500)
                    .HasColumnName("Random_Percentage");

                entity.Property(e => e.TotalNumberStudies).HasColumnName("TotalNumber_Studies");
            });

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.HasKey(e => e.PrefixIncId);

                entity.ToTable("Prefix");

                entity.Property(e => e.PrefixIncId).HasColumnName("Prefix_Inc_ID");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.PrefixName)
                    .HasMaxLength(30)
                    .HasColumnName("Prefix_Name");
            });

            modelBuilder.Entity<ProcDetail>(entity =>
            {
                entity.HasKey(e => e.ProcDetailIncCode)
                    .HasName("proc_detail_inc_code");

                entity.ToTable("proc_detail");

                entity.Property(e => e.ProcDetailIncCode).HasColumnName("proc_detail_inc_code");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .HasColumnName("Machine_Name")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcName)
                    .HasMaxLength(50)
                    .HasColumnName("Proc_Name");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("Room_Name")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.HasKey(e => e.ProcCode)
                    .HasName("proc_code");

                entity.ToTable("procedures");

                entity.Property(e => e.ProcCode).HasColumnName("proc_code");

                entity.Property(e => e.BodyPart).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Modality_Name");

                entity.Property(e => e.NoVisit).HasColumnName("no_visit");

                entity.Property(e => e.ProcComment)
                    .HasMaxLength(500)
                    .HasColumnName("proc_comment");

                entity.Property(e => e.ProcDuration).HasColumnName("proc_duration");

                entity.Property(e => e.ProcId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("proc_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcName)
                    .HasMaxLength(100)
                    .HasColumnName("proc_name");

                entity.Property(e => e.ProcNameOther)
                    .HasMaxLength(50)
                    .HasColumnName("Proc_Name_Other");

                entity.Property(e => e.ProcNameStandard)
                    .HasMaxLength(100)
                    .HasColumnName("proc_name_standard");

                entity.Property(e => e.ProcPrice).HasColumnName("proc_price");

                entity.Property(e => e.WeightCheck)
                    .HasColumnName("weight_check")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReferringPhysician>(entity =>
            {
                entity.HasKey(e => e.RefPhyCode)
                    .HasName("ref_phy_code");

                entity.ToTable("referring_physician");

                entity.Property(e => e.RefPhyCode).HasColumnName("ref_phy_code");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.RefPhyAddress)
                    .HasMaxLength(100)
                    .HasColumnName("ref_phy_address");

                entity.Property(e => e.RefPhyClinicAddress)
                    .HasMaxLength(100)
                    .HasColumnName("ref_phy_clinic_address");

                entity.Property(e => e.RefPhyComment)
                    .HasMaxLength(100)
                    .HasColumnName("ref_phy_comment");

                entity.Property(e => e.RefPhyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Ref_Phy_Date");

                entity.Property(e => e.RefPhyEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_email");

                entity.Property(e => e.RefPhyFax)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_fax");

                entity.Property(e => e.RefPhyId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_id");

                entity.Property(e => e.RefPhyMobile)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_mobile");

                entity.Property(e => e.RefPhyName)
                    .HasMaxLength(50)
                    .HasColumnName("ref_phy_name");

                entity.Property(e => e.RefPhyPhone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_phone");

                entity.Property(e => e.RefPhyRestriction)
                    .HasColumnName("Ref_Phy_Restriction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefPhyRestrictionComment)
                    .HasMaxLength(500)
                    .HasColumnName("Ref_Phy_Restriction_Comment");

                entity.Property(e => e.RefPhyRestrictionFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("Ref_Phy_Restriction_From");

                entity.Property(e => e.RefPhyRestrictionTo)
                    .HasColumnType("datetime")
                    .HasColumnName("Ref_Phy_Restriction_To");

                entity.Property(e => e.RefPhySex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ref_phy_sex");

                entity.Property(e => e.RefPhySpeciality)
                    .HasMaxLength(50)
                    .HasColumnName("ref_phy_speciality");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionIncId);

                entity.ToTable("Region");

                entity.Property(e => e.RegionIncId).HasColumnName("Region_inc_id");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(50)
                    .HasColumnName("Region_Name");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(e => e.RepIncId)
                    .HasName("PK_Reports_1");

                entity.Property(e => e.RepIncId).HasColumnName("rep_inc_id");

                entity.Property(e => e.RepAuditUser)
                    .HasMaxLength(50)
                    .HasColumnName("rep_Audit_user");

                entity.Property(e => e.RepComment)
                    .HasMaxLength(255)
                    .HasColumnName("rep_comment");

                entity.Property(e => e.RepDictateUser)
                    .HasMaxLength(50)
                    .HasColumnName("rep_Dictate_user");

                entity.Property(e => e.RepFilePath)
                    .HasMaxLength(255)
                    .HasColumnName("rep_file_path");

                entity.Property(e => e.RepName)
                    .HasMaxLength(50)
                    .HasColumnName("rep_name");

                entity.Property(e => e.RepStatus)
                    .HasColumnName("rep_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepStatusDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rep_status_date");

                entity.Property(e => e.RepStructureTabName)
                    .HasMaxLength(50)
                    .HasColumnName("rep_structure_tab_name");

                entity.Property(e => e.RepStudyIncIdDet).HasColumnName("rep_study_inc_id_det");

                entity.Property(e => e.RepType).HasColumnName("rep_type");

                entity.Property(e => e.RepTypist)
                    .HasMaxLength(50)
                    .HasColumnName("rep_Typist");

                entity.Property(e => e.RepVerifyUser)
                    .HasMaxLength(50)
                    .HasColumnName("rep_verify_user");

                entity.HasOne(d => d.RepStudyIncIdDetNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.RepStudyIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Study_Inc_ID_rep_study_inc_id_det");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.RoleModalities)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_Modalities");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("Role_Name");

                entity.Property(e => e.RoleReportModality)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_Report_Modality");

                entity.Property(e => e.RoleRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_Rights");

                entity.Property(e => e.RoleRisAccountingRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_AccountingRights");

                entity.Property(e => e.RoleRisInventoryRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_InventoryRights");

                entity.Property(e => e.RoleRisParticipationRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_ParticipationRights");

                entity.Property(e => e.RoleRisPatientInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_PatientInfo");

                entity.Property(e => e.RoleRisSiteInformationRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_SiteInformationRights");

                entity.Property(e => e.RoleRisStatusRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_RIS_StatusRights");
            });

            modelBuilder.Entity<RolesCp>(entity =>
            {
                entity.HasKey(e => e.CpRoleId)
                    .HasName("PK_CP_Roles");

                entity.ToTable("Roles_CP");

                entity.Property(e => e.CpRoleId).HasColumnName("CP_Role_ID");

                entity.Property(e => e.CpBranchName)
                    .HasMaxLength(50)
                    .HasColumnName("CP_Branch_Name");

                entity.Property(e => e.CpRoleName)
                    .HasMaxLength(50)
                    .HasColumnName("CP_Role_Name");

                entity.Property(e => e.CpRoleRights)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CP_Role_Rights");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.RoomCode)
                    .HasName("room_code");

                entity.ToTable("rooms");

                entity.Property(e => e.RoomCode).HasColumnName("room_code");

                entity.Property(e => e.MainInvDef)
                    .HasColumnName("main_inv_def")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RoomLocation)
                    .HasMaxLength(50)
                    .HasColumnName("room_location");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("room_name");

                entity.Property(e => e.SecInvDef)
                    .HasColumnName("sec_inv_def")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SendingFile>(entity =>
            {
                entity.HasKey(e => e.SendingFilesAutoInc)
                    .HasName("SendingFiles_Auto_Inc");

                entity.Property(e => e.SendingFilesAutoInc).HasColumnName("SendingFiles_Auto_Inc");

                entity.Property(e => e.SendingFilesClassUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SendingFiles_ClassUID");

                entity.Property(e => e.SendingFilesDeleteFileAfterSending)
                    .HasColumnName("SendingFiles_DeleteFileAfterSending")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingFilesFileName)
                    .HasMaxLength(255)
                    .HasColumnName("SendingFiles_FileName");

                entity.Property(e => e.SendingFilesMorphRule)
                    .HasMaxLength(255)
                    .HasColumnName("SendingFiles_MorphRule");

                entity.Property(e => e.SendingFilesSendingStudiesDet).HasColumnName("SendingFiles_SendingStudies_Det");

                entity.Property(e => e.SendingFilesSopUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SendingFiles_SopUID");

                entity.Property(e => e.SendingFilesStatus)
                    .HasColumnName("SendingFiles_Status")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SendingFilesSendingStudiesDetNavigation)
                    .WithMany(p => p.SendingFiles)
                    .HasForeignKey(d => d.SendingFilesSendingStudiesDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SendingStudies_SendingFiles");
            });

            modelBuilder.Entity<SendingStudy>(entity =>
            {
                entity.HasKey(e => e.SendingStudiesAutoInc)
                    .HasName("SendingStudies_Auto_Inc");

                entity.Property(e => e.SendingStudiesAutoInc).HasColumnName("SendingStudies_Auto_Inc");

                entity.Property(e => e.SendingStudiesCompressionType)
                    .HasColumnName("SendingStudies_CompressionType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesDestAet)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SendingStudies_DestAET");

                entity.Property(e => e.SendingStudiesDestHostName)
                    .HasMaxLength(50)
                    .HasColumnName("SendingStudies_DestHostName");

                entity.Property(e => e.SendingStudiesDestIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SendingStudies_DestIP");

                entity.Property(e => e.SendingStudiesDestPort).HasColumnName("SendingStudies_DestPort");

                entity.Property(e => e.SendingStudiesEndTransmissionAt)
                    .HasColumnType("datetime")
                    .HasColumnName("SendingStudies_End_Transmission_At");

                entity.Property(e => e.SendingStudiesFailedFilesCount)
                    .HasColumnName("SendingStudies_FailedFilesCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesIslocked)
                    .HasColumnName("SendingStudies_ISLocked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesPatId)
                    .HasMaxLength(50)
                    .HasColumnName("SendingStudies_PatID");

                entity.Property(e => e.SendingStudiesPatName)
                    .HasMaxLength(50)
                    .HasColumnName("SendingStudies_PatName");

                entity.Property(e => e.SendingStudiesPriority)
                    .HasColumnName("SendingStudies_Priority")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesQualityFactor)
                    .HasColumnName("SendingStudies_Quality_Factor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesRetries)
                    .HasColumnName("SendingStudies_Retries")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesSentFilesCount)
                    .HasColumnName("SendingStudies_SentFilesCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesStartTransmissionFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("SendingStudies_Start_Transmission_From");

                entity.Property(e => e.SendingStudiesStartTransmissionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("SendingStudies_StartTransmissionTime");

                entity.Property(e => e.SendingStudiesStudyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SendingStudies_StudyDate");

                entity.Property(e => e.SendingStudiesStudyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SendingStudies_StudyID");

                entity.Property(e => e.SendingStudiesStudyUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SendingStudies_StudyUID");

                entity.Property(e => e.SendingStudiesSuccessFilesCount)
                    .HasColumnName("SendingStudies_SuccessFilesCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendingStudiesTotalFilesCount)
                    .HasColumnName("SendingStudies_TotalFilesCount")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasKey(e => e.SeriesIncId)
                    .HasName("Series_Inc_ID");

                entity.ToTable("series");

                entity.HasIndex(e => e.SeriesUid, "IX_SeriesUID")
                    .HasFillFactor(90);

                entity.Property(e => e.SeriesIncId).HasColumnName("Series_Inc_ID");

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Body_Part");

                entity.Property(e => e.Contrast).HasMaxLength(50);

                entity.Property(e => e.EchoTime)
                    .HasColumnName("Echo_Time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageOrientation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Image_Orientation");

                entity.Property(e => e.Machine).HasMaxLength(50);

                entity.Property(e => e.Modality)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(50)
                    .HasColumnName("procedure_name");

                entity.Property(e => e.RepetitionTime)
                    .HasColumnName("Repetition_Time")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriesDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Series_Date_Time");

                entity.Property(e => e.SeriesDescripition)
                    .HasMaxLength(250)
                    .HasColumnName("Series_Descripition");

                entity.Property(e => e.SeriesDirectory)
                    .HasMaxLength(255)
                    .HasColumnName("Series_Directory");

                entity.Property(e => e.SeriesInstances)
                    .HasColumnName("Series_Instances")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriesNumber)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Series_Number");

                entity.Property(e => e.SeriesPatientId)
                    .HasMaxLength(64)
                    .HasColumnName("Series_Patient_ID");

                entity.Property(e => e.SeriesStatus)
                    .HasColumnName("Series_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SeriesStudyUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Series_Study_UID");

                entity.Property(e => e.SeriesUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Series_UID");

                entity.Property(e => e.StudyIncIdDet).HasColumnName("Study_inc_ID_det");

                entity.Property(e => e.ViewPosition)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("View_Position");

                entity.HasOne(d => d.StudyIncIdDetNavigation)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.StudyIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_series_Studies");
            });

            modelBuilder.Entity<SharedStudiesUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shared_Studies_Users");

                entity.Property(e => e.SharedStudiesIncId).HasColumnName("Shared_Studies_Inc_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<SharedStudy>(entity =>
            {
                entity.HasKey(e => e.SharedStudiesIncId);

                entity.ToTable("Shared_Studies");

                entity.Property(e => e.SharedStudiesIncId).HasColumnName("Shared_Studies_Inc_ID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CreatorId).HasColumnName("Creator_ID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiration_Date");

                entity.Property(e => e.IsAnonymize).HasColumnName("Is_Anonymize");

                entity.Property(e => e.IsEveryOne).HasColumnName("Is_EveryOne");

                entity.Property(e => e.Message).HasMaxLength(1200);

                entity.Property(e => e.NeedPassword).HasColumnName("Need_Password");

                entity.Property(e => e.Reason).HasMaxLength(300);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Start_Date");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.UrlUid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Url_UID");
            });

            modelBuilder.Entity<SiteInfo>(entity =>
            {
                entity.ToTable("SiteInfo");

                entity.Property(e => e.SiteInfoId).HasColumnName("SiteInfo_ID");

                entity.Property(e => e.CustDir)
                    .HasMaxLength(150)
                    .HasColumnName("Cust_Dir")
                    .HasDefaultValueSql("('C:\\PxViewerWeb\\ViewerSite\\CustomerDir')");

                entity.Property(e => e.IsWindowsAuth).HasColumnName("Is_WindowsAuth");

                entity.Property(e => e.SslPort).HasColumnName("SSL_Port");

                entity.Property(e => e.UltimaIp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Ultima_IP");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateId).HasColumnName("State_ID");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.StateAbbr)
                    .HasMaxLength(5)
                    .HasColumnName("state_abbr");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .HasColumnName("State_Name");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_States_Country");
            });

            modelBuilder.Entity<Study>(entity =>
            {
                entity.HasKey(e => e.StudyIncId)
                    .HasName("Study_Inc_ID");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.AccessionNoDetStr)
                    .HasMaxLength(64)
                    .HasColumnName("AccessionNo_Det_Str")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessionNoIncDet).HasColumnName("AccessionNo_Inc_Det");

                entity.Property(e => e.AeTitle)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("AE_Title");

                entity.Property(e => e.AppType)
                    .HasColumnName("App_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.CrStatus).HasColumnName("CR_Status");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer_Name");

                entity.Property(e => e.EdStatus)
                    .HasColumnName("ED_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HandledDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Handled_Date");

                entity.Property(e => e.HandledName)
                    .HasMaxLength(50)
                    .HasColumnName("Handled_Name");

                entity.Property(e => e.InstitutionName)
                    .HasMaxLength(64)
                    .HasColumnName("Institution_Name");

                entity.Property(e => e.InsurName)
                    .HasMaxLength(100)
                    .HasColumnName("Insur_Name");

                entity.Property(e => e.InsurPaymentMethod)
                    .HasColumnName("Insur_Payment_Method")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsurType)
                    .HasMaxLength(100)
                    .HasColumnName("Insur_Type");

                entity.Property(e => e.IsCanceled).HasColumnName("Is_Canceled");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .HasColumnName("Machine_Name");

                entity.Property(e => e.ModalitiesInStudy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Modalities_In_Study");

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Modality_Name");

                entity.Property(e => e.MppsUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("MPPS_UID");

                entity.Property(e => e.PatHeight)
                    .HasColumnName("Pat_Height")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PatIncIdDet).HasColumnName("Pat_Inc_ID_Det");

                entity.Property(e => e.PatWeight)
                    .HasColumnName("Pat_Weight")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PeerReviewStatus)
                    .HasColumnName("PeerReview_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PeriodIncId).HasColumnName("Period_Inc_ID");

                entity.Property(e => e.ProcEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("Proc_End");

                entity.Property(e => e.ProcName)
                    .HasMaxLength(50)
                    .HasColumnName("Proc_Name");

                entity.Property(e => e.ProcStart)
                    .HasColumnType("datetime")
                    .HasColumnName("Proc_Start");

                entity.Property(e => e.RadiologistName)
                    .HasMaxLength(50)
                    .HasColumnName("Radiologist_Name");

                entity.Property(e => e.Reasons).HasMaxLength(500);

                entity.Property(e => e.ReceivingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Receiving_Date");

                entity.Property(e => e.RefPhyName)
                    .HasMaxLength(50)
                    .HasColumnName("Ref_Phy_Name");

                entity.Property(e => e.ReportAuditor)
                    .HasMaxLength(50)
                    .HasColumnName("report_auditor");

                entity.Property(e => e.ReportDictator)
                    .HasMaxLength(50)
                    .HasColumnName("report_dictator");

                entity.Property(e => e.ReportTypist)
                    .HasMaxLength(50)
                    .HasColumnName("report_typist");

                entity.Property(e => e.ReportVerifier)
                    .HasMaxLength(50)
                    .HasColumnName("report_verifier");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("Room_Name");

                entity.Property(e => e.RpDescription)
                    .HasMaxLength(64)
                    .HasColumnName("RP_Description");

                entity.Property(e => e.StatusArchived)
                    .HasColumnName("Status_Archived")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusProtected)
                    .HasColumnName("Status_Protected")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusReported)
                    .HasColumnName("Status_Reported")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.StatusRis)
                    .HasColumnName("Status_RIS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusStat)
                    .HasColumnName("Status_STAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusTransferred)
                    .HasColumnName("Status_Transferred")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusTransferredTo)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Transferred_To");

                entity.Property(e => e.StatusViewed)
                    .HasColumnName("Status_Viewed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyBpHigh)
                    .HasColumnName("study_bp_high")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyBpLow)
                    .HasColumnName("study_bp_low")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyCines)
                    .HasColumnName("Study_Cines")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Study_Description");

                entity.Property(e => e.StudyDirectory)
                    .HasMaxLength(255)
                    .HasColumnName("Study_Directory");

                entity.Property(e => e.StudyFindCategory)
                    .HasMaxLength(50)
                    .HasColumnName("Study_Find_Category");

                entity.Property(e => e.StudyFindDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Study_Find_Desc");

                entity.Property(e => e.StudyFindSystem)
                    .HasMaxLength(50)
                    .HasColumnName("Study_Find_System");

                entity.Property(e => e.StudyId)
                    .HasMaxLength(16)
                    .HasColumnName("Study_ID");

                entity.Property(e => e.StudyImages)
                    .HasColumnName("Study_Images")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyIncIdStr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Study_Inc_ID_Str");

                entity.Property(e => e.StudyKeyword)
                    .HasMaxLength(50)
                    .HasColumnName("Study_Keyword");

                entity.Property(e => e.StudyLocation)
                    .HasMaxLength(10)
                    .HasColumnName("Study_Location");

                entity.Property(e => e.StudyRbs)
                    .HasColumnName("study_rbs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyReceptionist)
                    .HasMaxLength(50)
                    .HasColumnName("Study_Receptionist");

                entity.Property(e => e.StudyReports)
                    .HasColumnName("Study_Reports")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudySeries)
                    .HasColumnName("Study_Series")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StudyUid)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Study_UID");

                entity.Property(e => e.StudyVoices)
                    .HasColumnName("Study_Voices")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Technician).HasMaxLength(50);

                entity.Property(e => e.UseWl)
                    .HasColumnName("Use_WL")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PatIncIdDetNavigation)
                    .WithMany(p => p.Studies)
                    .HasForeignKey(d => d.PatIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Studies_Patients");
            });

            modelBuilder.Entity<StudyDetail>(entity =>
            {
                entity.HasKey(e => e.StudyDetailsId);

                entity.ToTable("Study_Details");

                entity.Property(e => e.StudyDetailsId).HasColumnName("StudyDetails_ID");

                entity.Property(e => e.MsFirstReader).HasColumnName("MS_FirstReader");

                entity.Property(e => e.MsSecondReader).HasColumnName("MS_SecondReader");

                entity.Property(e => e.MsStatus)
                    .HasColumnName("MS_Status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MsThirdReader).HasColumnName("MS_ThirdReader");

                entity.Property(e => e.StudyIncIdDet).HasColumnName("Study_Inc_ID_Det");

                entity.Property(e => e.StudyPriority).HasColumnName("Study_Priority");

                entity.HasOne(d => d.StudyIncIdDetNavigation)
                    .WithMany(p => p.StudyDetails)
                    .HasForeignKey(d => d.StudyIncIdDet)
                    .HasConstraintName("FK_Study_Details_Studies");
            });

            modelBuilder.Entity<StudyInsur>(entity =>
            {
                entity.HasKey(e => e.StudyInsIncId);

                entity.ToTable("Study_Insur");

                entity.Property(e => e.StudyInsIncId).HasColumnName("Study_Ins_Inc_Id");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_Date");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(20)
                    .HasColumnName("Group_Number");

                entity.Property(e => e.InsurProvider)
                    .HasMaxLength(20)
                    .HasColumnName("Insur_Provider");

                entity.Property(e => e.PlaneName)
                    .HasMaxLength(50)
                    .HasColumnName("Plane_Name");

                entity.Property(e => e.PolicyNumber)
                    .HasMaxLength(20)
                    .HasColumnName("Policy_Number");

                entity.Property(e => e.SeAddress)
                    .HasMaxLength(50)
                    .HasColumnName("SE_Address");

                entity.Property(e => e.SeCity)
                    .HasMaxLength(20)
                    .HasColumnName("SE_City");

                entity.Property(e => e.SeCountry)
                    .HasMaxLength(20)
                    .HasColumnName("SE_Country");

                entity.Property(e => e.SeName)
                    .HasMaxLength(50)
                    .HasColumnName("SE_Name");

                entity.Property(e => e.SeState)
                    .HasMaxLength(20)
                    .HasColumnName("SE_State");

                entity.Property(e => e.SeZipCode)
                    .HasMaxLength(20)
                    .HasColumnName("SE_Zip_Code");

                entity.Property(e => e.StudyIncId).HasColumnName("Study_Inc_ID");

                entity.Property(e => e.SubAcceptAssignment).HasColumnName("Sub_AcceptAssignment");

                entity.Property(e => e.SubAddress)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Address");

                entity.Property(e => e.SubCity)
                    .HasMaxLength(20)
                    .HasColumnName("Sub_City");

                entity.Property(e => e.SubCoPay).HasColumnName("Sub_CoPay");

                entity.Property(e => e.SubCountry)
                    .HasMaxLength(20)
                    .HasColumnName("Sub_Country");

                entity.Property(e => e.SubDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Sub_DOB");

                entity.Property(e => e.SubFname)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_FName");

                entity.Property(e => e.SubGender)
                    .HasMaxLength(1)
                    .HasColumnName("Sub_Gender");

                entity.Property(e => e.SubLname)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_LName");

                entity.Property(e => e.SubMname)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_MName");

                entity.Property(e => e.SubName)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Name");

                entity.Property(e => e.SubPayeeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Payee_No");

                entity.Property(e => e.SubPayeeRelationship)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Payee_Relationship");

                entity.Property(e => e.SubPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Sub_Phone");

                entity.Property(e => e.SubSsn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sub_SSN");

                entity.Property(e => e.SubState)
                    .HasMaxLength(20)
                    .HasColumnName("Sub_State");

                entity.Property(e => e.SubZipCode)
                    .HasMaxLength(20)
                    .HasColumnName("Sub_Zip_Code");
            });

            modelBuilder.Entity<StudyLock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Study_Lock");

                entity.Property(e => e.AppType)
                    .HasColumnName("App_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LockTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lock_Time");

                entity.Property(e => e.StudyIncIdDet).HasColumnName("Study_inc_id_Det");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.StudyIncIdDetNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StudyIncIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Study_Inc_ID_Study_inc_iD_det_Lock");
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.ToTable("TimeZone");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZone_ID");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.TimeZoneName)
                    .HasMaxLength(50)
                    .HasColumnName("TimeZone_Name");

                entity.Property(e => e.UtcOffset).HasColumnName("UTC_Offset");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("u_id");

                entity.Property(e => e.UId).HasColumnName("u_id");

                entity.Property(e => e.AccountExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Account_Expire_Date");

                entity.Property(e => e.AccountStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Account_Start_Date");

                entity.Property(e => e.AccountType)
                    .HasColumnName("Account_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowedBranches)
                    .HasMaxLength(500)
                    .HasColumnName("Allowed_Branches");

                entity.Property(e => e.CpView).HasColumnName("Cp_View");

                entity.Property(e => e.DefaultBranch)
                    .HasMaxLength(50)
                    .HasColumnName("Default_Branch");

                entity.Property(e => e.DocUsers)
                    .HasMaxLength(500)
                    .HasColumnName("Doc_Users");

                entity.Property(e => e.DomainGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DomainGUID");

                entity.Property(e => e.EmrProviderName)
                    .HasMaxLength(50)
                    .HasColumnName("EMR_ProviderName");

                entity.Property(e => e.HPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("h_password");

                entity.Property(e => e.Otptoken)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OTPToken");

                entity.Property(e => e.PasswordRenewalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PasswordRenewal_Date");

                entity.Property(e => e.PasswordRenewalPeriod).HasColumnName("PasswordRenewal_Period");

                entity.Property(e => e.QuestionAnswer)
                    .HasMaxLength(200)
                    .HasColumnName("Question_Answer");

                entity.Property(e => e.QuestionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Question_Code");

                entity.Property(e => e.RAccountingInfo)
                    .HasColumnName("r_Accounting_Info")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RAccountingReports)
                    .HasColumnName("r_Accounting_Reports")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RBranches)
                    .HasColumnName("r_branches")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RCommonInfo)
                    .HasColumnName("r_Common_Info")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RCommonInventoryInfo)
                    .HasColumnName("r_Common_inventory_info")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RConsumptionInventory)
                    .HasColumnName("r_Consumption_Inventory")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RImages)
                    .HasColumnName("r_Images")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RInventoryInfo)
                    .HasColumnName("r_Inventory_Info")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RInventoryReports).HasColumnName("r_Inventory_reports");

                entity.Property(e => e.RModalities)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("r_modalities")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RMovies)
                    .HasColumnName("r_Movies")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RParticipation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("r_Participation");

                entity.Property(e => e.RPatInfo)
                    .HasColumnName("r_Pat_info")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RReportSections)
                    .HasColumnName("r_report_sections")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RReportStructure)
                    .HasColumnName("r_report_structure")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RReportTemplates)
                    .HasColumnName("r_report_templates")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RReports)
                    .HasColumnName("r_Reports")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("r_status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RUpdateSettings)
                    .HasColumnName("r_Update_Settings")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RVoices)
                    .HasColumnName("r_Voices")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RefUsers)
                    .HasMaxLength(500)
                    .HasColumnName("Ref_Users");

                entity.Property(e => e.RepStat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Rep_Stat");

                entity.Property(e => e.UAddress)
                    .HasMaxLength(50)
                    .HasColumnName("u_address");

                entity.Property(e => e.UAddress2)
                    .HasMaxLength(50)
                    .HasColumnName("u_address_2");

                entity.Property(e => e.UBirthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("u_birthdate");

                entity.Property(e => e.UCode).HasColumnName("U_Code");

                entity.Property(e => e.UComment)
                    .HasMaxLength(50)
                    .HasColumnName("u_comment");

                entity.Property(e => e.UCustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("U_CustomerName");

                entity.Property(e => e.UCvFilePath)
                    .HasMaxLength(255)
                    .HasColumnName("U_CV_File_Path");

                entity.Property(e => e.UDirectory)
                    .HasMaxLength(255)
                    .HasColumnName("u_directory");

                entity.Property(e => e.UEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("u_email");

                entity.Property(e => e.UFaxNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("u_fax_number");

                entity.Property(e => e.UFullname)
                    .HasMaxLength(50)
                    .HasColumnName("u_fullname");

                entity.Property(e => e.UJobCategory)
                    .HasColumnName("u_job_category")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UJobTitle)
                    .HasMaxLength(20)
                    .HasColumnName("u_job_title");

                entity.Property(e => e.ULanguage)
                    .HasColumnName("U_language")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ULocked).HasColumnName("u_Locked");

                entity.Property(e => e.ULockedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("u_LockedDate");

                entity.Property(e => e.UMireportProfile)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("u_mireport_profile");

                entity.Property(e => e.UMirisProfile)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("u_miris_profile")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("u_mobile");

                entity.Property(e => e.UName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_name");

                entity.Property(e => e.UPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_password");

                entity.Property(e => e.UPopMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_pop_mail");

                entity.Property(e => e.UPopMailPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_pop_mail_password");

                entity.Property(e => e.UPopPort).HasColumnName("U_Pop_Port");

                entity.Property(e => e.UPopServer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("U_Pop_Server");

                entity.Property(e => e.URestriction)
                    .HasColumnName("U_Restriction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.URestrictionComment)
                    .HasMaxLength(500)
                    .HasColumnName("U_Restriction_Comment");

                entity.Property(e => e.URestrictionFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("U_Restriction_From");

                entity.Property(e => e.URestrictionTo)
                    .HasColumnType("datetime")
                    .HasColumnName("U_Restriction_To");

                entity.Property(e => e.USex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("u_sex");

                entity.Property(e => e.USignatureFilePath)
                    .HasMaxLength(255)
                    .HasColumnName("u_signature_file_path");

                entity.Property(e => e.USmtpMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_smtp_mail");

                entity.Property(e => e.USmtpMailPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("u_smtp_mail_password");

                entity.Property(e => e.USmtpPort).HasColumnName("U_Smtp_Port");

                entity.Property(e => e.USmtpServer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("U_Smtp_Server");

                entity.Property(e => e.UTel)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("u_tel");

                entity.Property(e => e.UTel2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("u_tel_2");

                entity.Property(e => e.UVtoolsProfile)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("u_vtools_profile");

                entity.Property(e => e.UserSettings)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Settings")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserStudies).HasMaxLength(200);
            });

            modelBuilder.Entity<UserBranch>(entity =>
            {
                entity.HasKey(e => e.URId)
                    .HasName("U_R_ID");

                entity.ToTable("User_Branch");

                entity.Property(e => e.URId).HasColumnName("U_R_ID");

                entity.Property(e => e.AccountExpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Account_Expire_Date");

                entity.Property(e => e.AccountStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Account_Start_Date");

                entity.Property(e => e.AccountType).HasColumnName("Account_Type");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.CpRoleId).HasColumnName("CP_Role_ID");

                entity.Property(e => e.DocUsers)
                    .HasMaxLength(500)
                    .HasColumnName("Doc_Users");

                entity.Property(e => e.RefUsers)
                    .HasMaxLength(500)
                    .HasColumnName("Ref_Users");

                entity.Property(e => e.RepStat)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Rep_Stat");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.UDirectory)
                    .HasMaxLength(255)
                    .HasColumnName("u_directory");

                entity.Property(e => e.USignatureFilePath)
                    .HasMaxLength(255)
                    .HasColumnName("u_signature_file_path");

                entity.Property(e => e.UserIdDet).HasColumnName("User_ID_Det");

                entity.HasOne(d => d.UserIdDetNavigation)
                    .WithMany(p => p.UserBranches)
                    .HasForeignKey(d => d.UserIdDet)
                    .HasConstraintName("FK_User_Branch_users_new");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_Group");

                entity.Property(e => e.GroupCode).HasColumnName("Group_Code");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UsersParticipation>(entity =>
            {
                entity.HasKey(e => e.ParticipationIncId)
                    .HasName("Participation_Inc_ID");

                entity.ToTable("Users_Participation");

                entity.Property(e => e.ParticipationIncId).HasColumnName("Participation_Inc_ID");

                entity.Property(e => e.ParticipationComment)
                    .HasMaxLength(500)
                    .HasColumnName("Participation_Comment");

                entity.Property(e => e.ParticipationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Participation_Date");

                entity.Property(e => e.ParticipationStudyDet).HasColumnName("Participation_Study_Det");

                entity.Property(e => e.ParticipationUserName)
                    .HasMaxLength(50)
                    .HasColumnName("Participation_User_Name");

                entity.Property(e => e.UIdDet).HasColumnName("U_ID_Det");

                entity.Property(e => e.UProcPartPerc1).HasColumnName("U_Proc_PartPerc_1");

                entity.Property(e => e.UProcPartPerc2).HasColumnName("U_Proc_PartPerc_2");

                entity.Property(e => e.UProcPerc)
                    .HasColumnName("U_Proc_Perc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UProcValue)
                    .HasColumnName("U_Proc_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UValue)
                    .HasColumnName("U_Value")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserType).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ParticipationStudyDetNavigation)
                    .WithMany(p => p.UsersParticipations)
                    .HasForeignKey(d => d.ParticipationStudyDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Study_Inc_ID_Participation_Study_Det");

                entity.HasOne(d => d.UIdDetNavigation)
                    .WithMany(p => p.UsersParticipations)
                    .HasForeignKey(d => d.UIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Participation_users");
            });

            modelBuilder.Entity<UsersProc>(entity =>
            {
                entity.HasKey(e => e.UProcIncId)
                    .HasName("U_Proc_Inc_ID");

                entity.ToTable("Users_Proc");

                entity.Property(e => e.UProcIncId).HasColumnName("U_Proc_Inc_ID");

                entity.Property(e => e.ProcCodeDet).HasColumnName("Proc_Code_Det");

                entity.Property(e => e.ProcName)
                    .HasMaxLength(50)
                    .HasColumnName("Proc_Name");

                entity.Property(e => e.UFullname)
                    .HasMaxLength(50)
                    .HasColumnName("U_Fullname");

                entity.Property(e => e.UIdDet).HasColumnName("U_ID_Det");

                entity.Property(e => e.UProcPartPerc1)
                    .HasColumnName("U_Proc_PartPerc_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UProcPartPerc2)
                    .HasColumnName("U_Proc_PartPerc_2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UProcPerc)
                    .HasColumnName("U_Proc_Perc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UProcValue)
                    .HasColumnName("U_Proc_Value")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ProcCodeDetNavigation)
                    .WithMany(p => p.UsersProcs)
                    .HasForeignKey(d => d.ProcCodeDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Proc_procedures");

                entity.HasOne(d => d.UIdDetNavigation)
                    .WithMany(p => p.UsersProcs)
                    .HasForeignKey(d => d.UIdDet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Users_Proc_users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
