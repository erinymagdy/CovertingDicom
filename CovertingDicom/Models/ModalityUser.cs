using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class ModalityUser
    {
        public int ModalityUserId { get; set; }
        public string? Modality { get; set; }
        public string? UName { get; set; }
    }
}
