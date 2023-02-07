using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface IPatientRepository
    {
        public void AddPatient(string name, string lastName, string phoneNumber,
           string email, int? statusId, bool male, DateTime birthday);
        public List<PatientDto> GetAllPatients();
        public void UpdatePatientById(PatientDto patient);
        public void UpdateIsDeletedPatientById(PatientDto patient);
        public List<PatientDto> GetAllPatientsByStatusId(int Id_Status);
    }
}
