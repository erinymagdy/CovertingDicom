using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Patient
    {
        public Patient()
        {
            JobOrders = new HashSet<JobOrder>();
            Studies = new HashSet<Study>();
        }

        public int PatIncId { get; set; }
        public string? PatId { get; set; }
        public string? PatName { get; set; }
        public DateTime? PatBirthDatetime { get; set; }
        public string? PatSex { get; set; }
        public string? PatPhoneHome { get; set; }
        public string? PatPhoneBusiness { get; set; }
        public string? PatAddress { get; set; }
        public string? PatAddressOther { get; set; }
        public DateTime? PatFirstvisitDatetime { get; set; }
        public string? PatSsn { get; set; }
        public int? PatInsuranceNumber { get; set; }
        public string? PatNameEnglish { get; set; }
        public string? PatPrefix { get; set; }
        public string? PatCity { get; set; }
        public byte? PatMaritalStatus { get; set; }
        public byte? PatReligion { get; set; }
        public string? PatDriverslicenseNumber { get; set; }
        public string? PatNationality { get; set; }
        public string? PatAllergies { get; set; }
        public string? PatEmail { get; set; }
        public string? PatComment { get; set; }
        public int? PatStudies { get; set; }
        public byte? PatPrevBreastOperations { get; set; }
        public byte? PatBreastSide { get; set; }
        public byte? PatAgeMenarche { get; set; }
        public byte? PatAgeMenopause { get; set; }
        public byte? PatAgeFirstBaby { get; set; }
        public byte? PatPara { get; set; }
        public byte? PatOutcome { get; set; }
        public byte? PatLactation { get; set; }
        public byte? PatFamilyHistory { get; set; }
        public byte? PatFamilyMother { get; set; }
        public byte? PatFamilySister { get; set; }
        public byte? PatFamilyAunt { get; set; }
        public byte? PatFamilyOther { get; set; }
        public byte? PatContraceptive { get; set; }
        public byte? PatContraceptiveNo { get; set; }
        public byte? PatFamilyAgeDiscovery { get; set; }
        public byte? PatFamilyOutcome { get; set; }
        public string? PatHistory { get; set; }
        public string? PatRespPerson { get; set; }
        public string? PatRespPersonRole { get; set; }
        public string? PatRespOrg { get; set; }
        public string? PatSexNeutered { get; set; }
        public string? PatSpecies { get; set; }
        public string? PatBreed { get; set; }
        public int? UIdDet { get; set; }
        public byte? PatRace { get; set; }
        public byte? PatEthnicity { get; set; }
        public byte? PatVfc { get; set; }
        public short? PrimaryLanguage { get; set; }
        public short? SecondaryLanguage { get; set; }
        public short? PatCountry { get; set; }
        public string? PatPhoneCell { get; set; }
        public string? PatEmailSec { get; set; }
        public string? PatEmergContact { get; set; }
        public string? PatEmergPhone { get; set; }
        public short? PatState { get; set; }
        public string? PatZipCode { get; set; }

        public virtual ICollection<JobOrder> JobOrders { get; set; }
        public virtual ICollection<Study> Studies { get; set; }
    }
}
