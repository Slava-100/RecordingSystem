using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class TimeTableDto
    {
        public int Id { get; set; }
        public DoctorDto Doctor { get; set; } 
        public DayOfWeekDto DayOfWeek { get; set; }
        public TimeSpanDto TimeSpan { get; set; }

    }
}
