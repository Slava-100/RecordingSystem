using RecordingSystem.DAL.Models;

namespace RecordingSystem.DAL.Interfaces
{
    public interface ITimeRecordingRepository
    {
        public void AddTimeRecording(TimeRecordingDto timeRecording);
        public List<TimeRecordingDto> GetAllTimeRecordingsByDoctorId(int id);
        public void UpdateTimeRecordingById(TimeRecordingDto timeRecordingById);
    }
}
