using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class PatientRepository
    {
        public void AddPatient(string name, string lastName, string phoneNumber, string email, int? statusId, bool male, DateTime birthday)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddPatient,
                    new { name, lastName, phoneNumber, email, statusId, male, birthday },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<PatientDto> GetAllPatients()
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<PatientDto>(StoredNamesProcedures.GettAllPatients,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void UpdatePatient(PatientDto patient)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdatePatientById,
                    new
                    {
                        patient.Id,
                        patient.Name,
                        patient.LastName,
                        patient.PhoneNumber,
                        patient.Email,
                        patient.StatusId,
                        patient.Male,
                        patient.IsDeleted,
                        patient.Birthday
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
