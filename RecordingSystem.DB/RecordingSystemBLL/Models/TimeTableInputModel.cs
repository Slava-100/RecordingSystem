
namespace RecordingSystem.BLL.Models
{
    public class TimeTableInputModel
    {
        public int? DoctorId { get; set; }
        public int? DayOfWeekId { get; set; }
        public int? TimeSpanId { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimeTableInputModel model &&
                    DoctorId == model.DoctorId &&
                    DayOfWeekId == model.DayOfWeekId &&
                    TimeSpanId == model.TimeSpanId;
        }
    }
}
