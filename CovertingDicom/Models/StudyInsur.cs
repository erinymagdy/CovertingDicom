using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class StudyInsur
    {
        public int StudyInsIncId { get; set; }
        public int? StudyIncId { get; set; }
        public string? InsurProvider { get; set; }
        public string? PlaneName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? PolicyNumber { get; set; }
        public string? GroupNumber { get; set; }
        public string? SeName { get; set; }
        public string? SeAddress { get; set; }
        public string? SeCity { get; set; }
        public string? SeState { get; set; }
        public string? SeCountry { get; set; }
        public string? SeZipCode { get; set; }
        public string? SubName { get; set; }
        public DateTime? SubDob { get; set; }
        public string? SubGender { get; set; }
        public string? SubCity { get; set; }
        public string? SubState { get; set; }
        public string? SubZipCode { get; set; }
        public string? SubCountry { get; set; }
        public string? SubPayeeNo { get; set; }
        public string? SubPayeeRelationship { get; set; }
        public float? SubCoPay { get; set; }
        public string? SubFname { get; set; }
        public string? SubMname { get; set; }
        public string? SubLname { get; set; }
        public string? SubSsn { get; set; }
        public string? SubAddress { get; set; }
        public string? SubPhone { get; set; }
        public byte? SubAcceptAssignment { get; set; }
    }
}
