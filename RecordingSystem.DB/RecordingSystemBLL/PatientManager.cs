using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class PatientManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public IPatientRepository PatientRepository { get; set; }

        public PatientManager()
        {
            PatientRepository = new PatientRepository();
        }

        public List<PatientOutputModel> GetAllPatients()
        {
            var patients = PatientRepository.GetAllPatients();
            var result = _mapperrr.MapListPatientDtoToListPatientOutputModel(patients);
            return result;
        }

        public List<PatientOutputModel> GetAllPatientsByStatusId(int id)
        {
            var patients = PatientRepository.GetAllPatientsByStatusId(id);
            var result = _mapperrr.MapListPatientDtoToListPatientOutputModelByStatusId(patients);
            return result;
        }

        public void AddPatient(PatientInputModel patient)
        {
            var patientDto = _mapperrr.MapPatientInputModelToPatientDto(patient);
            PatientRepository.AddPatient(patientDto);
        }

        public void UpdatePatient(PatientInputModel patient)
        {
            var patientDto = _mapperrr.MapUpdatePatientInputModelToPatientDto(patient);
            PatientRepository.UpdatePatientById(patientDto);
        }
        public void DeletePatient(UpdateIsDeletedPatientModel patient)
        {
            var patientDto = _mapperrr.MapUpdateIsDeletedPatientModelToPatientDto(patient);
            PatientRepository.UpdateIsDeletedPatientById(patientDto);
        }

    }
}
