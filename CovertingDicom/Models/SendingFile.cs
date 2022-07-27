using System;
using System.Collections.Generic;

namespace CovertingDicom.Models
{
    public partial class SendingFile
    {
        public int SendingFilesAutoInc { get; set; }
        public int? SendingFilesSendingStudiesDet { get; set; }
        public string? SendingFilesFileName { get; set; }
        public byte? SendingFilesDeleteFileAfterSending { get; set; }
        public int? SendingFilesStatus { get; set; }
        public string? SendingFilesSopUid { get; set; }
        public string? SendingFilesClassUid { get; set; }
        public string? SendingFilesMorphRule { get; set; }

        public virtual SendingStudy? SendingFilesSendingStudiesDetNavigation { get; set; }
    }
}
