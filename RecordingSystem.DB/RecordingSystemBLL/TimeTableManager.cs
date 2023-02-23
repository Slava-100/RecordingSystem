using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
    public class TimeTableManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public ITimeTableRepository TimeTableRepository { get; set; }

        public TimeTableManager()
        {
            TimeTableRepository = new TimeTableRepository();
        }

        public List<TimeTableOutputModel> GetTimeTableByDoctorId(int id)
        {
            var timeTables = TimeTableRepository.GetTimeTableByDoctorId(id);
            var result = _mapperrr.MapListTimeTableDtoToListTimeTableOutputModel(timeTables);
            return result;
        }
    }
}
