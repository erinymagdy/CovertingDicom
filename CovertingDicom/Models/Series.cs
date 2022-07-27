using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Series
    {
        public Series()
        {
            InstInfos = new HashSet<InstInfo>();
        }

        public int SeriesIncId { get; set; }
        public int? StudyIncIdDet { get; set; }
        public string? SeriesPatientId { get; set; }
        public string? SeriesStudyUid { get; set; }
        public string? SeriesUid { get; set; }
        public string? SeriesNumber { get; set; }
        public short? SeriesInstances { get; set; }
        public DateTime? SeriesDateTime { get; set; }
        public string? Modality { get; set; }
        public string? Machine { get; set; }
        public string? BodyPart { get; set; }
        public string? ProcedureName { get; set; }
        public string? Contrast { get; set; }
        public string? SeriesDescripition { get; set; }
        public short? SeriesStatus { get; set; }
        public string? SeriesDirectory { get; set; }
        public float? RepetitionTime { get; set; }
        public float? EchoTime { get; set; }
        public string? ImageOrientation { get; set; }
        public string? ViewPosition { get; set; }

        public virtual Study? StudyIncIdDetNavigation { get; set; }
        public virtual ICollection<InstInfo> InstInfos { get; set; }
    }
}
