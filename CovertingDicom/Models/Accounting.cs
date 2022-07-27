using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Accounting
    {
        public Accounting()
        {
            AccountingTrans = new HashSet<AccountingTran>();
        }

        public int AccountIncId { get; set; }
        public int? StudyIncIdDet { get; set; }
        public float? ProcPrice { get; set; }
        public int? RecipteNumber { get; set; }
        public string? AccountReceptionist { get; set; }
        public float? DiscountValue { get; set; }
        public string? DiscountComment { get; set; }
        public byte? PaymentMethod { get; set; }
        public float? PaymentValue { get; set; }
        public float? AdditionalValue { get; set; }
        public string? AdditionalComment { get; set; }
        public DateTime? RemainderPaymentDate { get; set; }
        public float? RemainderPaid { get; set; }
        public DateTime? ReturnDate { get; set; }
        public float? ReturnAmount { get; set; }
        public string? ReturnComment { get; set; }
        public float? InsurProcMainPrice { get; set; }
        public float? InsurProcPrice { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DepositDate { get; set; }
        public float? DepositValue { get; set; }
        public int? ReceiptNoOther { get; set; }
        public DateTime? RemainderPaidVisaDate { get; set; }
        public float? VisaValue { get; set; }
        public float? RemainderPaidVisa { get; set; }
        public string? PayeeName { get; set; }
        public string? PayeeInsurNo { get; set; }
        public string? PayeeRelationship { get; set; }
        public float? RemPaidCash2 { get; set; }
        public float? RemPaidVisa2 { get; set; }
        public DateTime? RemPaidCash2Date { get; set; }
        public DateTime? RemPaidVisa2Date { get; set; }
        public string? RemPaidCash2User { get; set; }
        public string? RemPaidVisa2User { get; set; }
        public string? RemPaidCashUser { get; set; }
        public string? RemPaidVisaUser { get; set; }
        public string? DepositUser { get; set; }
        public string? AdditionUser { get; set; }
        public string? DiscountUser { get; set; }
        public string? ReturnUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public string? ScheduledUser { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public string? ArrivedUser { get; set; }
        public DateTime? InProgressDate { get; set; }
        public string? InProgressUser { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string? CompletedUser { get; set; }
        public DateTime? PendingDate { get; set; }
        public string? PendingUser { get; set; }
        public DateTime? HandledAllDate { get; set; }
        public string? HandledAllUser { get; set; }
        public string? HandledByName { get; set; }
        public DateTime? HandledFilmOnlyDate { get; set; }
        public string? HandledFilmOnlyUser { get; set; }
        public DateTime? HandledReportOnlyDate { get; set; }
        public string? HandledReportOnlyUser { get; set; }
        public DateTime? DiscontinueDate { get; set; }
        public string? DiscontinueUser { get; set; }
        public DateTime? CanceledDate { get; set; }
        public string? CanceledUser { get; set; }
        public string? CanceledReason { get; set; }
        public float? InsurReturnAmount { get; set; }
        public DateTime? InsurReturnDate { get; set; }
        public string? InsurReturnUser { get; set; }

        public virtual Study? StudyIncIdDetNavigation { get; set; }
        public virtual ICollection<AccountingTran> AccountingTrans { get; set; }
    }
}
