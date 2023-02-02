using RecordingSystem.DAL.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class DoctorRepository
    {
        public List<DoctorDto> GetAllDoctors()
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();
                return sqlConnection.Query<DoctorDto>(StoredNamesProcedures.GetAllDoctors,
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public List<ServiceDto> GetAllDoctorByServices(int id)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<ServiceDto> result = new List<ServiceDto>();

                sqlConnection.Open();
                return sqlConnection.Query < ServiceDto, DoctorDto, ServiceDto>(
                    StoredNamesProcedures.GetAllServiceByDoctor,
                    (service, doctor) => 
                    {
                        ServiceDto crnt = null;
                        foreach (var tmpS in result)
                        {
                            if(tmpS.Id == service.Id)
                            {
                                crnt = tmpS;
                            }
                        }
                        if (crnt is null)
                        {
                            crnt = service;
                            result.Add(crnt);
                        }
                        return service;
                    },
                    new { id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
