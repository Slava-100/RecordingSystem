using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class ActiveRecordingRepository : IActiveRecordingRepository
    {
        public void AddActiveRecording(int patientId, int doctorId, DateTime date)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddActiveRecording,
                    new { patientId, doctorId, date },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateComingInActiveRecordingById(ActiveRecordingDto recording)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateComingInActiveRecordingById,
                    new
                    { recording.Coming },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateIsDeletedActiveRecordingById(ActiveRecordingDto recording)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedActiveRecordingById,
                    new
                    { recording.IsDeleted },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<ActiveRecordingDto> GetAllActiveRecordingsByPatientId(int id)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<ActiveRecordingDto> result = new List<ActiveRecordingDto>();

                sqlConnection.Open();
                sqlConnection.Query<PatientDto, ActiveRecordingDto, DoctorDto, CabinetDto, ActiveRecordingDto>(
                    StoredNamesProcedures.GetAllActiveRecordingsByPatientId,
                    (patient, activeRecording, doctor, cabinet) =>
                    {
                        activeRecording.Patient = patient;
                        result.Add(activeRecording);
                        activeRecording.Doctor = doctor;
                        activeRecording.Cabinet= cabinet;

                        return activeRecording;
                    },
                    new { Id_Patient = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
