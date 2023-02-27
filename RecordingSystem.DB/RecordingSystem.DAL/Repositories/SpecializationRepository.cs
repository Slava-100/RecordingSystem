using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class SpecializationRepository : ISpecializationRepository
    {
        public List<SpecializationDto> GetAllSpecializations()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<SpecializationDto>(StoredNamesProcedures.GetAllSpecializations,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public SpecializationDto GetSpecializationById(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.QuerySingle<SpecializationDto>(StoredNamesProcedures.GetSpecializationById,
                    new { Id = id},
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void AddSpecialization(SpecializationDto specializationDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddSpecialization,
                    new { specializationDto.Name },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
