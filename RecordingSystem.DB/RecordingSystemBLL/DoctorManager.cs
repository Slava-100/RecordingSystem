using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class DoctorManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public IDoctorRepository DoctorRepository { get; set; }

        public DoctorManager()
        {
            DoctorRepository = new DoctorRepository();
        }

        public List<DoctorOutputModel> GetAllDoctors()
        {
            var doctors = DoctorRepository.GetAllDoctors();
            var result = _mapperrr.MapDoctorDtoToDoctorOutputModel(doctors);

            return result;
        }

        public List<DoctorOutputModel> GetAllDoctorsByServiceId(int id)
        {
            var doctors = DoctorRepository.GetAllDoctorsByServiceId(id);
            var result = _mapperrr.MapDoctorDtoToDoctorOutputModel(doctors);

            return result;
        }

        public List<DoctorOutputModel> GetAllDoctorBySpecializationId(int id)
        {
            var doctors = DoctorRepository.GetAllDoctorBySpecializationId(id);
            var result = _mapperrr.MapDoctorDtoToDoctorOutputModel(doctors);

            return result;
        }
        public List<DoctorOutputModel> GetAllFreeDoctorsByDayOfWeekId(int id)
        {
            var doctors = DoctorRepository.GetAllFreeDoctorsByDayOfWeekId(id);
            var result = _mapperrr.MapDoctorDtoToDoctorOutputModel(doctors);

            return result;
        }

        public void AddDoctor(DoctorInputModel doctor)
        {
            var doctorDto = _mapperrr.MapDoctorInputModelToDoctorDto(doctor);
            DoctorRepository.AddDoctor(doctorDto);
        }

        public void UpdateDoctor(DoctorInputModel doctor)
        {
            var doctorDto = _mapperrr.MapDoctorInputModelToDoctorDto(doctor);
            DoctorRepository.UpdateDoctor(doctorDto);
        }
    }
}
