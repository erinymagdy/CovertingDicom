using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class ReferringPhysician
    {
        public int RefPhyCode { get; set; }
        public string? RefPhyId { get; set; }
        public string? RefPhyName { get; set; }
        public string? RefPhySex { get; set; }
        public string? RefPhyAddress { get; set; }
        public string? RefPhySpeciality { get; set; }
        public string? RefPhyPhone { get; set; }
        public string? RefPhyMobile { get; set; }
        public string? RefPhyEmail { get; set; }
        public string? RefPhyFax { get; set; }
        public string? RefPhyClinicAddress { get; set; }
        public string? RefPhyComment { get; set; }
        public byte? RefPhyRestriction { get; set; }
        public DateTime? RefPhyRestrictionFrom { get; set; }
        public DateTime? RefPhyRestrictionTo { get; set; }
        public string? RefPhyRestrictionComment { get; set; }
        public DateTime? RefPhyDate { get; set; }
        public string? CustomerName { get; set; }
    }
}
