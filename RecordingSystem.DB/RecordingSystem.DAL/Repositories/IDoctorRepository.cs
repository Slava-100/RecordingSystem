using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface IDoctorRepository
    {
        public List<DoctorDto> GetAllDoctors();
        public void AddDoctor(string name, string lastName, bool male, string phoneNumber,
            string email, int? specializationId, int? cabinetId, DateTime birthday);
        public void UpdateDoctor(DoctorDto doctor);
        public void UpdateIsDeletedDoctorById(DoctorDto doctor);
        public List<DoctorDto> GetAllDoctorsByServiceId(int id);
        public List<DoctorDto> GetAllDoctorBySpecializationId(int id);
        public List<DoctorDto> GetAllFreeDoctorsByDayOfWeekId(int Id_DayOfWeek);
    }
}
