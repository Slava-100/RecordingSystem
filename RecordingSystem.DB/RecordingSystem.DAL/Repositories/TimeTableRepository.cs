using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using System.Data;
using RecordingSystem.DAL.Options;

namespace RecordingSystem.DAL.Repositories
{
    public class TimeTableRepository : ITimeTableRepository
    {
        public List<TimeTableDto> GetTimeTableByDoctorId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                List<TimeTableDto> result = new List<TimeTableDto>();

                sqlConnection.Open();
                sqlConnection.Query<TimeTableDto, DoctorDto,SpecializationDto,CabinetDto,DayOfWeekDto,TimeSpanDto,TimeTableDto>(StoredNamesProcedures.GetTimeTableByDoctorId,
                    (timeTable, doctor, specialization, cabinet, dayOfWeek, timeSpan) =>
                    {
                        if (result.Count == 0 || !result.Any(tt => tt.DayOfWeek.Id == dayOfWeek.Id && tt.TimeSpan.Id == timeSpan.Id && tt.Doctor.Id == doctor.Id))
                        {
                            timeTable.Doctor = doctor;

                            if (timeTable.Doctor is not null)
                            {
                                timeTable.DoctorId = timeTable.Doctor.Id;
                            }

                            doctor.Specialization = specialization;
                            doctor.Cabinet = cabinet;
                            timeTable.DayOfWeek = dayOfWeek;

                            if (timeTable.DayOfWeek is not null)
                            {
                                timeTable.DayOfWeekId = timeTable.DayOfWeek.Id;
                            }

                            timeTable.TimeSpan = timeSpan;

                            if (timeTable.TimeSpan is not null)
                            {
                                timeTable.TimeSpanId = timeTable.TimeSpan.Id;
                            }
                            
                            result.Add(timeTable);
                        }

                        return timeTable;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
                
                return result;
            }
        }

        public void AddTimeTable(TimeTableDto timeTableDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddTimeTable,
                    new { timeTableDto.DoctorId, timeTableDto.DayOfWeekId, timeTableDto.TimeSpanId },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
