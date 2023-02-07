using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class CabinetRepository : ICabinetRepository
    {
        public void AddCabinet(int number, bool? status)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddCabinet,
                    new { number, status },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<CabinetDto> GetAllCabinets()
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<CabinetDto>(StoredNamesProcedures.GetAllCabinets,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void UpdateCabinetById(CabinetDto cabinet)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
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
