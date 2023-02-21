using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class ServiceManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public IServiceRepository ServiceRepository { get; set; }

        public ServiceManager()
        {
            ServiceRepository = new ServiceRepository();
        }

        public void AddService(ServiceInputModel service)
        {
            var serviceDto = _mapperrr.MapServiceInputModelToServiceDto(service);
            ServiceRepository.AddService(serviceDto);
        }

        public void UpdateService(UpdateServiceInputModel service)
        {
            var serviceDto = _mapperrr.MapUpdateServiceInputModelToServiceDto(service);
            ServiceRepository.UpdateServiceById(serviceDto);
        }

        public void UpdateIsDeletedServiceById(UpdateServiceInputModel service)
        {
            var serviceDto = _mapperrr.MapUpdateServiceInputModelToServiceDto(service);
            ServiceRepository.UpdateIsDeletedServiceById(serviceDto);
        }

        public List<ServiceOutputModel> GetAllServicesByDoctorId(int id)
        {
            var service = ServiceRepository.GetAllServicesByDoctorId(id);
            var result = _mapperrr.MapListServiceDtoToListServiceOutputModel(service);
            return result;
        }
        public List<ServiceOutputModel> GetAllServiceByMale(bool male)
        {
            var service = ServiceRepository.GetAllServiceByMale(male);
            var result = _mapperrr.MapListServiceDtoToListServiceOutputModel(service);
            return result;
        }
        public List<ServiceOutputModel> GetAllServiceBySpecializationId(int id)
        {
            var service = ServiceRepository.GetAllServiceBySpecializationId(id);
            var result = _mapperrr.MapListServiceDtoToListServiceOutputModel(service);
            return result;
        }
    }
}
