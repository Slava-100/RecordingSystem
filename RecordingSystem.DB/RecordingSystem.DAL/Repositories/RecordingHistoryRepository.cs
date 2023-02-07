using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class RecordingHistoryRepository
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

        public List<RecordingHistoryDto> GetRecordingHistoryByPatientId(int id)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<RecordingHistoryDto> result = new List<RecordingHistoryDto>();

                sqlConnection.Open();
                sqlConnection.Query<RecordingHistoryDto, ActiveRecordingDto, PatientDto, DoctorDto, DiagnosisDto, RecordingHistoryDto>(
                    StoredNamesProcedures.GetRecordingHistoryByPatientId,
                    (recordingHistory, activeRecording, patient, doctor, diagnosis) =>
                    {
                        recordingHistory.Id = recordingHistory.Id;
                        recordingHistory.ActiveRecordingId = recordingHistory.ActiveRecordingId;
                        recordingHistory.Patient = patient;
                        recordingHistory.Doctor = doctor;
                        recordingHistory.Diagnosis = diagnosis;

                        return recordingHistory;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
