using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class CabinetManager
    {
        Mapperrr _mapperrr = new Mapperrr();
        public ICabinetRepository CabinetRepository { get; set; }

        public CabinetManager()
        {
            CabinetRepository = new CabinetRepository();
        }

        public List<CabinetOutputModel> GetAllCabinets()
        {
            var cabinets = CabinetRepository.GetAllCabinets();
            var result = _mapperrr.MapListCabinetDtoToListCabinetOutputModel(cabinets);
            return result;
        }

        public void AddCabinet(CabinetInputModel cabinet)
        {
            var cabinetDto = _mapperrr.MapCabinetInputModelToCabinetDto(cabinet);
            CabinetRepository.AddCabinet(cabinetDto);
        }

        public void UpdateCabinetById(UpdateCabinetInputModel cabinet)
        {
            var cabinetDto = _mapperrr.MapUpdateCabinetInputModelToCabinetDto(cabinet);
            CabinetRepository.UpdateCabinetById(cabinetDto);
        }
    }
}
