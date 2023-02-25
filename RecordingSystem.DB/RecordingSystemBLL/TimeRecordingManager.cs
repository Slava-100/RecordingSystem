using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class TimeRecordingManager
    {
        private DateTime dateTimeNow = DateTime.Now;
        private Mapperrr _mapperrr = new Mapperrr();
        public ITimeRecordingRepository TimeRecordingRepository { get; set; }

        public TimeRecordingManager()
        {
            TimeRecordingRepository = new TimeRecordingRepository();
        }

        public List<TimeRecordingOutputModel> GetAllTimeRecordingsByDoctorId(int id)
        {
            var timeRecordings = TimeRecordingRepository.GetAllTimeRecordingsByDoctorId(id);
            var result = _mapperrr.MapListTimeRecordingDtoToListTimeRecordingOutputModel(timeRecordings);
            return result;
        }

        public void AddTimeRecording(TimeRecordingInputModel timeRecording)
        {
            var timeRecordingDto = _mapperrr.MapTimeRecordingInputModelToTimeRecordingDto(timeRecording);
            TimeRecordingRepository.AddTimeRecording(timeRecordingDto);
        }

        public void UpdateTimeRecordingById(UpdateTimeRecordingInputModel timeRecording)
        {
            var timeRecordingDto = _mapperrr.MapUpdateTimeRecordingInputModelToTimeRecordingDto(timeRecording);
            TimeRecordingRepository.UpdateTimeRecordingById(timeRecordingDto);
        }

        public void FillAllTimeRecordingInForAWeek()
        {
            //TimeRecordingRepository.
        }
    }
}
