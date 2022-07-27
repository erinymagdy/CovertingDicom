using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class Language
    {
        public int LanguageId { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageAbbreviation { get; set; }
        public string? LanguageDirection { get; set; }
    }
}
