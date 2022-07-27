using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Room
    {
        public int RoomCode { get; set; }
        public string? RoomName { get; set; }
        public string? RoomLocation { get; set; }
        public int? MainInvDef { get; set; }
        public int? SecInvDef { get; set; }
    }
}
