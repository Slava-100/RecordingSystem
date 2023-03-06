using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;
using System.ComponentModel.DataAnnotations;

namespace RecordingSystem.BLL
{
    public class ActiveRecordingManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public IActiveRecordingRepository ActiveRecordingRepository { get; set; }

        public ActiveRecordingManager()
        {
            ActiveRecordingRepository = new ActiveRecordingRepository();
        }

        public List<ActiveRecordingOutputModel> GetAllActiveRecordingsByPatientId(int id)
        {
            var activeRecording = ActiveRecordingRepository.GetAllActiveRecordingsByPatientId(id);
            var result = _mapperrr.MapListActiveRecordingDtotoListActiveRecordingOutputModel(activeRecording);
            return result;
        }

        public void AddActiveRecording(ActiveRecordingInputModel activeRecording)
        {
            var activeRecordingDto = _mapperrr.MapActiveRecordingInputModelToActiveRecordingDto(activeRecording);
            ActiveRecordingRepository.AddActiveRecording(activeRecordingDto);
        }

        public void UpdateComingInActiveRecordingById(UpdateActiveRecordingModel activeRecording)
        {
            var activeRecordingDto = _mapperrr.MapUpdateActiveRecordingModelToActiveRecordingDto(activeRecording);
            ActiveRecordingRepository.UpdateComingInActiveRecordingById(activeRecordingDto);
        }

        public void UpdateIsDeletedActiveRecordingById(UpdateIsDeletedActiveRecordingModel activeRecording)
        {
            var activeRecordingDto = _mapperrr.MapUpdateIsDeletedActiveRecordingModelToActiveRecordingDto(activeRecording);
            ActiveRecordingRepository.UpdateIsDeletedActiveRecordingById(activeRecordingDto);
        }
    }
}
