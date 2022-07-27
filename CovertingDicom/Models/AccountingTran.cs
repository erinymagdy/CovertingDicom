using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class AccountingTran
    {
        public int TransIncId { get; set; }
        public DateTime? TransDate { get; set; }
        public float? TransProcPrice { get; set; }
        public float? TransDepositValue { get; set; }
        public float? TransPaymentValue { get; set; }
        public float? TransRemainderPaid { get; set; }
        public float? TransReturnAmount { get; set; }
        public float? TransDiscountValue { get; set; }
        public float? TransAdditionalValue { get; set; }
        public int? TransReceiptNo { get; set; }
        public DateTime? TransReceiptDate { get; set; }
        public byte? TransType { get; set; }
        public string? TransUserName { get; set; }
        public float? TransVisaValue { get; set; }
        public float? TransRemainderPaidVisa { get; set; }
        public int? ProcessType { get; set; }
        public int? TransItemCode { get; set; }
        public int? AccountIncId { get; set; }

        public virtual Accounting? AccountInc { get; set; }
    }
}
