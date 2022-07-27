using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Dic
    {
        public int Id { get; set; }
        public string? SourceName { get; set; }
        public string? DestName { get; set; }
    }
}
