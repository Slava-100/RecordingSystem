using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL
{
    public class DoctorManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public IDoctorRepository DoctorRepository { get; set; }

        public DoctorManager(IDoctorRepository repository)
        {
            DoctorRepository = repository;
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


    }
}
