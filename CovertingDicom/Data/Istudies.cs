using CovertingDicom.Models;
using System.Threading.Tasks;
using System.Collections;
using CovertingDicom.ViewModels;

namespace CovertingDicom.Data

{
    public interface Istudies
    {

        IEnumerable<PatientStudyDetail> getPtatientData();
        string getPtatient(string id);

    }


}
