using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class TimeZone
    {
        public int TimeZoneId { get; set; }
        public string? TimeZoneName { get; set; }
        public string? Description { get; set; }
        public double? UtcOffset { get; set; }
    }
}
