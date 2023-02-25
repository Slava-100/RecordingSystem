using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Options;

namespace RecordingSystem.DAL.Repositories
{
    public class TimeSpanRepository : ITimeSpanRepository
    {
        public void AddTimeSpan(TimeSpanDto timeSpanDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddTimeSpan,
                    new { timeSpanDto.Start, timeSpanDto.End },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<TimeSpanDto> GetAllTimeSpan()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<TimeSpanDto>(StoredNamesProcedures.GetAllTimeSpan,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
