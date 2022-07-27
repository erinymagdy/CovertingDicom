using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class LanguageCustomer
    {
        public int LangInc { get; set; }
        public int UserlangId { get; set; }
        public string? CustomerName { get; set; }
        public string? LanguageFilePath { get; set; }
        public string? LanguageAbbreviation { get; set; }
        public bool? IsActive { get; set; }
    }
}
