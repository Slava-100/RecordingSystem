using RecordingSystem.DAL.Models;


namespace RecordingSystem.DAL.Interfaces
{
    public interface IRecordingHistoryRepository
    {
        public void AddRecordingHistory(int diagnosisId, int activeRecordingId);
        public List<RecordingHistoryDto> GetRecordingHistoryByPatientId(int id);
        public RecordingHistoryDto GetRecordingHistoryById(int id);
    }
}
