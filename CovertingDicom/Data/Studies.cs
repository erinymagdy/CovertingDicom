using CovertingDicom.Models;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using CovertingDicom.ViewModels;
namespace CovertingDicom.Data

{
    public class Studies : Istudies
    {
        private MIGlobalContext _mIGlobalContext { get; }
        public Studies(MIGlobalContext mIGlobalContext)
        {
            _mIGlobalContext = mIGlobalContext;
        }

        public IEnumerable<PatientStudyDetail> getPtatientData()
        {


            IEnumerable<PatientStudyDetail> examScheduleReport = (from e in _mIGlobalContext.Studies
                                                                  join s in _mIGlobalContext.Patients on e.PatIncIdDet equals s.PatIncId
                                                                  //left outr join r in _context.StudentExamRooms on s.StudentId equals r.StudentId
                                                                  select new PatientStudyDetail()
                                                                  {
                                                                      PatientID = e.PatIncIdDet,
                                                                      StudyID = e.StudyId,
                                                                      ImagePath = e.StudyDirectory,
                                                                      PatientName = s.PatName,
                                                                      ModalityName = e.ModalityName,

                                                                  });
            return examScheduleReport.ToList();
        }
        public string getPtatient(string id)
        {
            string path = _mIGlobalContext.Studies.Where(n => n.StudyId == id).Select(n => n.StudyDirectory).FirstOrDefault();
            return path;


        }
    }
}
