using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IActiveRecordingRepository
    {
        public void AddActiveRecording(ActiveRecordingDto activeRecordingDto);
        public void UpdateComingInActiveRecordingById(ActiveRecordingDto recording);
        public void UpdateIsDeletedActiveRecordingById(ActiveRecordingDto recording);
        public List<ActiveRecordingDto> GetAllActiveRecordingsByPatientId(int id);
    }
}
