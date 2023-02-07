using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public class SpecializationRepository : ISpecializationRepository
    {
        public List<SpecializationDto> GetAllSpecializations()
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<SpecializationDto>(StoredNamesProcedures.GetAllSpecializations,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void AddSpecialization(string name)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddSpecialization,
                    new { name },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
