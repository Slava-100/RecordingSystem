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
                sqlConnection.Open();
                return sqlConnection.Query<TimeTableDto, DoctorDto,SpecializationDto,CabinetDto,DayOfWeekDto,TimeSpanDto,TimeTableDto>(StoredNamesProcedures.GetTimeTableByDoctorId,
                    (timeTable, doctor, specialization, cabinet, dayOfWeek, timeSpan) =>
                    {
                        timeTable.Doctor = doctor;
                        doctor.Specialization = specialization;
                        doctor.Cabinet = cabinet;
                        timeTable.DayOfWeek = dayOfWeek;
                        timeTable.TimeSpan = timeSpan;

                        return timeTable;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
