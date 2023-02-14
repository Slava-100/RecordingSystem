using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IServiceRepository
    {
        public void AddService(ServiceDto serviceDto);
        public void UpdateService(ServiceDto service);
        public void UpdateServiceById(ServiceDto service);
        public void UpdateIsDeletedServiceById(ServiceDto service);
        public List<ServiceDto> GetAllDoctorInfoById(int id);
        public List<ServiceDto> GetAllServiceByMale(bool? male);

    }
}
