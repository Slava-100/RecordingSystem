using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using RecordingSystem.DAL.Options;
using RecordingSystem.DAL.Interfaces;

namespace RecordingSystem.DAL.Repositories
{
    public class DiagnosRepository : IDiagnosRepository
    {
        public void AddDiagnosis(string name, string recommendations)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddDiagnosis,
                    new { name, recommendations },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
