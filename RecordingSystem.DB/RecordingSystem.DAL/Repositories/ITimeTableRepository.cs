using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface ITimeTableRepository
    {
        public List<TimeTableDto> GetTimeTableByDoctorId(int Id);
    }
}
