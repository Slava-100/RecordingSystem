using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class DiagnosRepository
    {
        public void AddDiagnosis(string name, string recommendations)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddDiagnosis,
                    new { name, recommendations },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
