using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;

namespace RecordingSystem.BLL
{
    public class PatientManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public IPatientRepository PatientRepository { get; set; } 

        public List<PatientOutputModel> GetAllPatients()
        {
            var patients = PatientRepository.GetAllPatients();
            var result = _mapperrr.MapPatientDtoToPatientOutputModel(patients);
            return result;
        }
    }
}
