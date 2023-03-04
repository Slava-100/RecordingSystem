using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IDoctorRepository
    {
        public List<DoctorDto> GetAllDoctors();
        public void AddDoctor(DoctorDto doctorDto);
        public void UpdateDoctor(DoctorDto doctor);
        public void UpdateIsDeletedDoctorById(DoctorDto doctor);
        public List<DoctorDto> GetAllDoctorsByServiceId(int id);
        public List<DoctorDto> GetAllDoctorBySpecializationId(int id);
        public List<DoctorDto> GetAllFreeDoctorsByDayOfWeekId(int id);
        public DoctorDto GetDoctorById(int id);
    }
}
