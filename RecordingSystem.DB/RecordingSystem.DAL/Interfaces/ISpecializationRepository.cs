using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface ISpecializationRepository
    {
        public List<SpecializationDto> GetAllSpecializations();
        public void AddSpecialization(SpecializationDto specializationDto);
        public SpecializationDto GetSpecializationById(int id);
    }
}
