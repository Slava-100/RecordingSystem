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
            var result = _mapperrr.MapDoctorDtoToDoctorOutputModelById(doctors);

            return result;
        }
    }
}
