using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class TimeTableOutputModel
    {
        public int Id { get; set; }
        public DoctorOutputModel Doctor { get; set; }
        public DayOfWeekOutputModel DayOfWeek { get; set; }
        public TimeSpanOutputModel TimeSpan { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimeTableOutputModel model &&
                   Doctor.Equals(model.Doctor) &&
                   DayOfWeek.Equals(model.DayOfWeek) &&
                   TimeSpan.Equals(model.TimeSpan);
        }
    }
}
