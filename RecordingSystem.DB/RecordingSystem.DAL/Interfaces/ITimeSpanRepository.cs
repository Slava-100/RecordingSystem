using RecordingSystem.DAL.Models;

namespace RecordingSystem.DAL.Interfaces
{
    public interface ITimeSpanRepository
    {
        public void AddTimeSpan(TimeSpanDto timeSpanDto);
    }
}
