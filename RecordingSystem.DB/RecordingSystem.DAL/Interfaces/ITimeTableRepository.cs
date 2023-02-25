using RecordingSystem.DAL.Models;

namespace RecordingSystem.DAL.Interfaces
{
    public interface ITimeTableRepository
    {
        public List<TimeTableDto> GetTimeTableByDoctorId(int id);
        public void AddTimeTable(TimeTableDto timeTableDto);
    }
}
