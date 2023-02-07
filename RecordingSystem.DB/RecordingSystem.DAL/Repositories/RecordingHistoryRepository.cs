using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    internal class RecordingHistoryRepository
    {
        internal class DiagnosRepository
        {
            public void AddRecordingHistory(int diagnosisId, int activeRecordingId)
            {
                using (var sqlConnection = new SqlConnection(Options.sqlConnection))
                {
                    sqlConnection.Open();

                    sqlConnection.Execute(StoredNamesProcedures.AddRecordingHistory,
                        new { diagnosisId, activeRecordingId },
                        commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
