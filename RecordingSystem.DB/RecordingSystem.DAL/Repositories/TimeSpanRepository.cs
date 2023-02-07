using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class TimeSpanRepository : ITimeSpanRepository
    {
        public void AddTimeSpan(TimeSpan start, TimeSpan end)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddTimeSpan,
                    new { start, end },
                    commandType: CommandType.StoredProcedure);
            }
        }

    }
}
