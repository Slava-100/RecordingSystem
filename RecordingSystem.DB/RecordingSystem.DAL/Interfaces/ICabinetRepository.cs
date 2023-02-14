using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface ICabinetRepository
    {
        public void AddCabinet(CabinetDto cabinetDto);
        public List<CabinetDto> GetAllCabinets();
        public void UpdateCabinetById(CabinetDto cabinet);
    }
}
