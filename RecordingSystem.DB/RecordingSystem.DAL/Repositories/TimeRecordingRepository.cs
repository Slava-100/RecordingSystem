using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System.Data;

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
        public List<TimeRecordingDto> GetAllTimeRecordings()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<TimeRecordingDto>(
                    StoredNamesProcedures.GetAllTimeRecordings,
                    commandType: CommandType.StoredProcedure).ToList();
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

