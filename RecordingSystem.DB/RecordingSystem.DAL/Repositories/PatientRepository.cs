using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using System.Data;
using RecordingSystem.DAL.Options;

namespace RecordingSystem.DAL.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        public void AddPatient(PatientDto patientDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddPatient,
                    new { patientDto.Name, patientDto.LastName, patientDto.PhoneNumber, patientDto.Email, patientDto.StatusId, patientDto.Male, patientDto.Birthday },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<PatientDto> GetAllPatients()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<PatientDto>(StoredNamesProcedures.GettAllPatients,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void UpdatePatientById(PatientDto patient)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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
                        patient.Birthday
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateIsDeletedPatientById(PatientDto patient)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedPatientById,
                    new
                    {
                        patient.Id,
                        patient.IsDeleted 
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<PatientDto> GetAllPatientsByStatusId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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
                    new { Id_Status = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
