using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public class DayOfWeekRepository : IDayOfWeekRepository
    {
        public List<DayOfWeekDto> GetAllDayOfWeek()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<DayOfWeekDto>(StoredNamesProcedures.GetAllDayOfWeek,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void AddDayOfWeek(DayOfWeekDto dayOfWeek)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddDayOfWeek,
                    new { dayOfWeek.Name },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
