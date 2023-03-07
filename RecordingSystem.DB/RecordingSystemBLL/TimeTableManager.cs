using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Repositories;
using RecordingSystem.DAL.Models;
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

        public void AddTimeTable(TimeTableInputModel timeTable) 
        {
            var timeTableDto = _mapperrr.MapTimeTableInputModelToTimeTableDto(timeTable);
            TimeTableRepository.AddTimeTable(timeTableDto);
        }

        public void FillAllTimeTable()
        {
            IDoctorRepository DoctorRepository = new DoctorRepository();
            IDayOfWeekRepository DayOfWeekRepository = new DayOfWeekRepository();
            ITimeSpanRepository SpanRepository = new TimeSpanRepository();

            var listDoctors = DoctorRepository.GetAllDoctors();

            foreach (var d in listDoctors)
            {
                if (TimeTableRepository.GetTimeTableByDoctorId(d.Id).Count() == 0)
                {
                    foreach(var day in DayOfWeekRepository.GetAllDayOfWeek())
                    {
                        foreach(var span in SpanRepository.GetAllTimeSpan())
                        {
                            TimeTableDto timeTableDto = new TimeTableDto()
                            {
                                DoctorId = d.Id,
                                DayOfWeekId = day.Id,
                                TimeSpanId = span.Id
                            };
                            TimeTableRepository.AddTimeTable(timeTableDto);
                        }
                    }
                }
            }   
        }

        public void FillTimeTableByDoctorId(int doctorId)
        {
            IDayOfWeekRepository DayOfWeekRepository = new DayOfWeekRepository();
            ITimeSpanRepository SpanRepository = new TimeSpanRepository();

            if (TimeTableRepository.GetTimeTableByDoctorId(doctorId).Count() == 0)
            {
                foreach (var day in DayOfWeekRepository.GetAllDayOfWeek())
                {
                    foreach (var span in SpanRepository.GetAllTimeSpan())
                    {
                        TimeTableDto timeTableDto = new TimeTableDto()
                        {
                            DoctorId = doctorId,
                            DayOfWeekId = day.Id,
                            TimeSpanId = span.Id
                        };
                        TimeTableRepository.AddTimeTable(timeTableDto);
                    }
                }
            }
        }
    }
}
