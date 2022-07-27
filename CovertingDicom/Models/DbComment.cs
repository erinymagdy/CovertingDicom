using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class DbComment
    {
        public int CommentIncId { get; set; }
        public string? CommentTxt { get; set; }
        public int? CommentType { get; set; }
    }
}
