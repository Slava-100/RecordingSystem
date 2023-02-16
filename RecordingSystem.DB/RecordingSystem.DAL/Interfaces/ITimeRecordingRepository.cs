using RecordingSystem.DAL.Models;

namespace RecordingSystem.DAL.Interfaces
{
    public interface ITimeRecordingRepository
    {
        public void AddTimeRecording(TimeRecordingDto timeRecording);
        public List<TimeRecordingDto> GetAllTimeRecordings();
        public void UpdateTimeRecordingById(TimeRecordingDto timeRecordingById);
    }
}
