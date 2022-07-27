using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class SendingStudy
    {
        public SendingStudy()
        {
            SendingFiles = new HashSet<SendingFile>();
        }

        public int SendingStudiesAutoInc { get; set; }
        public string? SendingStudiesPatId { get; set; }
        public string? SendingStudiesPatName { get; set; }
        public string? SendingStudiesStudyUid { get; set; }
        public string? SendingStudiesStudyId { get; set; }
        public DateTime? SendingStudiesStudyDate { get; set; }
        public DateTime? SendingStudiesStartTransmissionTime { get; set; }
        public string? SendingStudiesDestAet { get; set; }
        public string? SendingStudiesDestIp { get; set; }
        public int? SendingStudiesDestPort { get; set; }
        public string? SendingStudiesDestHostName { get; set; }
        public int? SendingStudiesSentFilesCount { get; set; }
        public int? SendingStudiesTotalFilesCount { get; set; }
        public int? SendingStudiesIslocked { get; set; }
        public int? SendingStudiesRetries { get; set; }
        public int? SendingStudiesFailedFilesCount { get; set; }
        public int? SendingStudiesSuccessFilesCount { get; set; }
        public byte? SendingStudiesCompressionType { get; set; }
        public int? SendingStudiesQualityFactor { get; set; }
        public DateTime? SendingStudiesStartTransmissionFrom { get; set; }
        public DateTime? SendingStudiesEndTransmissionAt { get; set; }
        public byte? SendingStudiesPriority { get; set; }
        public byte? DeleteAfterSending { get; set; }

        public virtual ICollection<SendingFile> SendingFiles { get; set; }
    }
}
