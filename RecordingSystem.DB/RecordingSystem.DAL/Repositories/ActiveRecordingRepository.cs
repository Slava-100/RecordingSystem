using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class ActiveRecordingRepository : IActiveRecordingRepository
    {
        public void AddActiveRecording(ActiveRecordingDto activeRecordingDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddActiveRecording,
                    new { activeRecordingDto.PatientId, activeRecordingDto.DoctorId, activeRecordingDto.DateTime},
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateComingInActiveRecordingById(ActiveRecordingDto recording)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateComingInActiveRecordingById,
                    new
                    {   
                        recording.Id,
                        recording.Coming
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateIsDeletedActiveRecordingById(ActiveRecordingDto recording)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedActiveRecordingById,
                    new
                    {
                        recording.Id,
                        recording.IsDeleted
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<ActiveRecordingDto> GetAllActiveRecordingsByPatientId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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
                        activeRecording.Doctor.Cabinet = cabinet;

                        if (activeRecording.Patient is not null)
                        {
                            activeRecording.PatientId = activeRecording.Patient.Id;
                        }

                        if (activeRecording.Doctor is not null)
                        {
                            activeRecording.DoctorId = activeRecording.Doctor.Id;
                        }

                        if (activeRecording.Doctor.Cabinet is not null)
                        {
                            activeRecording.Doctor.CabinetId = activeRecording.Doctor.Cabinet.Id;
                        }

                        return activeRecording;
                    },
                    new { id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public ActiveRecordingDto GetActiveRecordingById(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                ActiveRecordingDto result = new ActiveRecordingDto();

                sqlConnection.Open();
                sqlConnection.Query<ActiveRecordingDto, PatientDto, DoctorDto, ActiveRecordingDto>(StoredNamesProcedures.GetActiveRecordingById,
                    (activeRecording, patient, doctor) =>
                    {
                        activeRecording.Doctor = doctor;
                        activeRecording.Patient = patient;
                        result = activeRecording;

                        return activeRecording;
                    },
                    new { Id = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure);

                return result;
            }
        }
    }
}
