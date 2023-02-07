using RecordingSystem.BLL.Models;
using RecordingSystem.DAL;
using AutoMapper;
using RecordingSystem.DAL.Repositories;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL
{
    public class DoctorManager
    {
        public List<DoctorOutputModel> GetAllDoctors()
        {
            DoctorRepository repository = new DoctorRepository();
            var doctors = repository.GetAllDoctors();

            var doctorDtoToDoctorOutputModelConfiguration = new MapperConfiguration(
                cfg => cfg.CreateMap<DoctorDto, DoctorOutputModel>()
                .ForMember(outputModel => outputModel.Name, opt => opt.MapFrom(doctorDto => doctorDto.Name)));

            IMapper mapper = doctorDtoToDoctorOutputModelConfiguration.CreateMapper();

            var result = mapper.Map<List<DoctorOutputModel>>(doctors);

            return result;
        }
    }
}