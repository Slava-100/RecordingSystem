using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Options;

namespace RecordingSystem.DAL.Repositories
{
    public class CabinetRepository : ICabinetRepository
    {
        public void AddCabinet(CabinetDto cabinetDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddCabinet,
                    new { cabinetDto.Number, cabinetDto.Status },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<CabinetDto> GetAllCabinets()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<CabinetDto>(StoredNamesProcedures.GetAllCabinets,
                    commandType: CommandType.StoredProcedure).ToList();
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
