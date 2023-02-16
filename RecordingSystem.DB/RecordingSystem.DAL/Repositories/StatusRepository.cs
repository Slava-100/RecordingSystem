using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class StatusRepository
    {
        public List<StatusDto> GetAllStatuses()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<StatusDto>(StoredNamesProcedures.GetAllStatuses,
                    commandType: CommandType.StoredProcedure).ToList();
            }

        }
        public void UpdateStatusById(StatusDto status)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateStatusById,
                    new
                    {
                        status.Id,
                        status.Name,
                        status.Discount
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
