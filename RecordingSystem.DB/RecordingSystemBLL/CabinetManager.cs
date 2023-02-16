using AutoMapper;
using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class CabinetManager
    {
        public List<CabinetOutputModel> GetAllCabinets()
        {
            CabinetRepository repository = new CabinetRepository();
            var service = repository.GetAllCabinets();

            var configuration = new MapperConfiguration(
                cfg => cfg.CreateMap<CabinetDto, CabinetOutputModel>());

            IMapper mapper = configuration.CreateMapper();

            return mapper.Map<List<CabinetOutputModel>>(service);

            //var result = _mapperrr.MapServiceDtoToProductOutputModel(products);

            //return result;
        }
    }
}
