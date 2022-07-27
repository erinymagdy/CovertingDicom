using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Integrations = new HashSet<Integration>();
        }

        public int BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? CustomerName { get; set; }
        public string? HeaderName { get; set; }
        public string? FooterName { get; set; }
        public string? BranchPhone { get; set; }
        public string? BranchAddress { get; set; }
        public string? ServerIp { get; set; }
        public string? ServerSqlName { get; set; }
        public string? ServerSqlUserName { get; set; }
        public string? ServerSqlUserPassword { get; set; }
        public byte[]? BranchLogo { get; set; }
        public int? ReceiptNo { get; set; }
        public string? UsersProfileDirectory { get; set; }
        public string? FtpIp { get; set; }
        public string? FtpUserName { get; set; }
        public string? FtpUserPassword { get; set; }
        public byte? FtpPassive { get; set; }
        public string? PatientsDir { get; set; }
        public string? UsersTemplates { get; set; }
        public int? ReceiptNoOther { get; set; }
        public string? MiRisUrl { get; set; }
        public string? MiReportUrl { get; set; }
        public string? WebViewUrl { get; set; }
        public string? StreamingUrl { get; set; }
        public string? PacsIp { get; set; }
        public string? PacsAe { get; set; }
        public int? PacsPort { get; set; }
        public string? SenderAet { get; set; }
        public string? CarePassportGuid { get; set; }
        public string? ServiceUrl { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string? Fax { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? WebSite { get; set; }
        public string? Email { get; set; }
        public int? CustId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? TimeZoneId { get; set; }
        public string? ImportDir { get; set; }
        public string? CareRadUrl { get; set; }

        public virtual ICollection<Integration> Integrations { get; set; }
    }
}
