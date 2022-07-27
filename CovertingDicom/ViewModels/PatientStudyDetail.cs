namespace CovertingDicom.ViewModels
{
    public class PatientStudyDetail
    {
        public int? PatientID { get; set; }
        public string? PatientName { get; set; }
        public string? ModalityName { get; set; }
        public string? StudyID { get; set; }
        public string? ImagePath { get; set; }
    }
}
