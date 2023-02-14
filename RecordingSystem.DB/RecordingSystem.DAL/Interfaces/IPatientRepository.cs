using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IPatientRepository
    {
        public void AddPatient(PatientDto patientDto);
        public List<PatientDto> GetAllPatients();
        public void UpdatePatientById(PatientDto patient);
        public void UpdateIsDeletedPatientById(PatientDto patient);
        public List<PatientDto> GetAllPatientsByStatusId(int id);
    }
}
