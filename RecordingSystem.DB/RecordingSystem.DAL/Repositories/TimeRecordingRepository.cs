using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using System.Data;
using RecordingSystem.DAL.Options;

namespace RecordingSystem.DAL.Repositories
{
    public class TimeRecordingRepository : ITimeRecordingRepository
    {

        public void AddTimeRecording(TimeRecordingDto timeRecording)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddTimeRecording,
                    new
                    {
                        timeRecording.Date,
                        timeRecording.TimeTableId,
                        timeRecording.Occupied
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public List<TimeRecordingDto> GetAllTimeRecordingsByDoctorId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                List<TimeRecordingDto> result = new List<TimeRecordingDto>();

                sqlConnection.Open();
                sqlConnection.Query<DoctorDto, TimeRecordingDto, TimeTableDto, TimeSpanDto, TimeRecordingDto>(StoredNamesProcedures.GetAllTimeRecordingsByDoctorId,
                    (doctor, timeRecording, timeTable, timeSpan) =>
                    {
                        if (!result.Any(tr => tr.TimeTable.Id == timeTable.Id && tr.Date == timeRecording.Date))
                        {
                            timeRecording.TimeTable = timeTable;
                            timeTable.TimeSpan = timeSpan;
                            timeTable.Doctor = doctor;
                            result.Add(timeRecording);
                        }

                        return timeRecording;
                    },
                    new { id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }


        public void UpdateTimeRecordingById(TimeRecordingDto timeRecordingById)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateTimeRecordingById,
                    new
                    {
                        timeRecordingById.Id,
                        timeRecordingById.Date,
                        timeRecordingById.TimeTable,
                        timeRecordingById.Occupied
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCabinetById(CabinetDto cabinet)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateCabinetById,
                    new
                    {
                        cabinet.Id,
                        cabinet.Number,
                        cabinet.Status
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}

