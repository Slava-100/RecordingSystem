using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class CabinetRepository
    {
        public void AddCabinet(int number, bool? status)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddCabinet,
                    new { number, status },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
