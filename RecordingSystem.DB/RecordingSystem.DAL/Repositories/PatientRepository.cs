using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class PatientRepository
    {
        public void AddPatient(string name, string lastName, string phoneNumber, string email, int? statusId, bool male, string birthday)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Query(StoredNamesProcedures.AddPatient,
                    new { name, lastName, phoneNumber, email, statusId, male, birthday },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
