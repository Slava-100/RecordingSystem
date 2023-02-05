using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class PatientRepository
    {
        public void AddPatient(string name, string lastName, string phoneNumber,
            string email, int? statusId, bool male, DateTime birthday)
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

        public void UpdatePatientById(PatientDto patient)
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

        public List<PatientDto> GetAllPatientsByStatusId(int Id_Status)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<PatientDto> result = new List<PatientDto>();

                sqlConnection.Open();
                sqlConnection.Query<StatusDto,PatientDto,PatientDto>(StoredNamesProcedures.GetAllPatientsByStatusId,
                    (status,patient) =>
                    {
                        patient.Status = status;
                        result.Add(patient);

                        return patient;
                    },
                    new { Id_Status },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
