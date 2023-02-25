using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Interfaces
{
    public interface IDayOfWeekRepository
    {
        public List<DayOfWeekDto> GetAllDayOfWeek();
    }
}
