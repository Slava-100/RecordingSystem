using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class SpecializationManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public ISpecializationRepository SpecializationRepository { get; set; }

        public SpecializationManager()
        {
            SpecializationRepository = new SpecializationRepository();
        }

        public List<SpecializationOutputModel> GetAllSpecializations()
        {
            var specializations = SpecializationRepository.GetAllSpecializations();
            var result = _mapperrr.MapListSpecializationDtoToListSpecializationOutputModel(specializations);
            return result;
        }

        public void AddSpecialization(SpecializationInputModel specialization)
        {
            var specializationDto = _mapperrr.MapSpecializationInputModelToSpecializationDto(specialization);
            SpecializationRepository.AddSpecialization(specializationDto);
        }

        public SpecializationOutputModel GetSpecializationById(int id)
        {
            var specialization = SpecializationRepository.GetSpecializationById(id);
            var result = _mapperrr.MapSpecializationDtoToSpecializationOutputModel(specialization);
            return result;
        }
    }
}
