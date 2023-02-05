using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class ActiveRecordingRepository
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
    }
}
