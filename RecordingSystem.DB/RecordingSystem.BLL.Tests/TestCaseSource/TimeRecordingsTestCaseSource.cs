using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Tests.TestCaseSource
{
    public static class TimeRecordingsTestCaseSource
    {
        public static IEnumerable GetAllTimeRecordingsByDoctorIdTestCaseSource()
        {
            List<TimeRecordingDto> timeRecordings = new List<TimeRecordingDto>();
            List<TimeRecordingOutputModel> expectedTimeRecordings = new List<TimeRecordingOutputModel>();
            int id = 1;

            yield return new Object[] { id, timeRecordings, expectedTimeRecordings };

            timeRecordings = new List<TimeRecordingDto>()
            {
                new TimeRecordingDto()
                {
                    Id = 1,
                    Date = new DateTime(2001, 01, 01),
                    TimeTableId = 1,
                    Occupied = false,
                    TimeTable = new TimeTableDto()
                    {
                        Id = 1,
                        Doctor = new DoctorDto()
                        {
                            Id = 1,
                            Specialization= new SpecializationDto()
                            {
                                Id = 1,
                            },
                            Cabinet = new CabinetDto()
                            {
                                Id = 1,
                            }
                        },
                        DayOfWeek = new DayOfWeekDto()
                        {
                            Id = 1
                        },
                        TimeSpan = new TimeSpanDto()
                        {
                            Id = 1
                        }
                    }
                }
            };

            expectedTimeRecordings = new List<TimeRecordingOutputModel> 
            { 
                new TimeRecordingOutputModel()
                {
                    Id = 1,
                    Date = new DateTime(2001, 01, 01),
                    TimeTableId = 1,
                    Occupied = false,
                    TimeTable = new TimeTableDto()
                    {
                        Id = 1,
                        Doctor = new DoctorDto()
                        {
                            Id = 1,
                            Specialization= new SpecializationDto()
                            {
                                Id = 1,
                            },
                            Cabinet = new CabinetDto()
                            {
                                Id = 1,
                            }
                        },
                        DayOfWeek = new DayOfWeekDto()
                        {
                            Id = 1
                        },
                        TimeSpan = new TimeSpanDto()
                        {
                            Id = 1
                        }
                    }
                } 
            };

            yield return new Object[] { id, timeRecordings, expectedTimeRecordings };
        }
    }
}
