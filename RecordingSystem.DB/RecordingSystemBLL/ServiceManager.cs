using AutoMapper;
using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class ServiceManager
    {
        //Mapperrr _mapperrr = new Mapperrr();
        public ServiceOutputModel GetAllDoctorInfoById(int id)
        {
            ServiceRepository repository = new ServiceRepository();
            var service = repository.GetAllDoctorInfoById(id);

            var configuration = new MapperConfiguration(
                cfg => cfg.CreateMap<ServiceDto, ServiceOutputModel>());

            IMapper mapper = configuration.CreateMapper();

            return mapper.Map<ServiceOutputModel>(service);

            //var result = _mapperrr.MapServiceDtoToProductOutputModel(products);

            //return result;
        }
    }
}
