using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;
using RecordingSystem.DAL.Options;
using RecordingSystem.DAL.Interfaces;

namespace RecordingSystem.DAL.Repositories
{
    public class RecordingHistoryRepository : IRecordingHistoryRepository
    {
        public void AddRecordingHistory(int diagnosisId, int activeRecordingId)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddRecordingHistory,
                    new { diagnosisId, activeRecordingId },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<RecordingHistoryDto> GetRecordingHistoryByPatientId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                List<RecordingHistoryDto> result = new List<RecordingHistoryDto>();

                sqlConnection.Open();
                sqlConnection.Query<RecordingHistoryDto, ActiveRecordingDto, PatientDto, DoctorDto, DiagnosisDto, RecordingHistoryDto>(
                    StoredNamesProcedures.GetRecordingHistoryByPatientId,
                    (recordingHistory, activeRecording, patient, doctor, diagnosis) =>
                    {
                        activeRecording.Patient = patient;
                        activeRecording.Doctor = doctor;
                        recordingHistory.ActiveRecording = activeRecording;
                        recordingHistory.Diagnosis = diagnosis;
                        result.Add(recordingHistory);

                        return recordingHistory;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
                
                return result;
            }
        }

        public RecordingHistoryDto GetRecordingHistoryById(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                RecordingHistoryDto result = new RecordingHistoryDto();

                sqlConnection.Open();
                sqlConnection.Query<RecordingHistoryDto, ActiveRecordingDto, PatientDto, DoctorDto, DiagnosisDto, RecordingHistoryDto>(
                    StoredNamesProcedures.GetRecordingHistoryById,
                    (recordingHistory, activeRecording, patient, doctor, diagnosis) =>
                    {
                        activeRecording.Patient = patient;
                        activeRecording.Doctor = doctor;
                        recordingHistory.ActiveRecording = activeRecording;
                        recordingHistory.Diagnosis = diagnosis;
                        result = recordingHistory;

                        return recordingHistory;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure);

                return result;
            }
        }
    }
}
