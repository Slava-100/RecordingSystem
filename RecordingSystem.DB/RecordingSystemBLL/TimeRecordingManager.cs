using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class TimeRecordingManager
    {

        Mapperrr _mapperrr = new Mapperrr();
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
    }
}
