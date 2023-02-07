using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class TimeTableRepository : ITimeTableRepository
    {
        public List<TimeTableDto> GetTimeTableByDoctorId(int Id)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
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
                    new { Id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
