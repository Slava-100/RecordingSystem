using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;


namespace RecordingSystem.DAL.Repositories
{
    public class ServiceRepository
    {
        public void AddService(string name, float price, int? specializationId, bool? male)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddService,
                    new { name, price, specializationId, male },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateService(ServiceDto service)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdatePatientById,
                    new
                    {
                        service.Id,
                        service.Name,
                        service.Price,
                        service.SpecializationId,
                        service.IsDeleted,
                        service.Male
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateServiceById(ServiceDto service)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateServiceById,
                    new
                    {
                        service.Id,
                        service.Name,
                        service.Price,
                        service.SpecializationId,
                        service.Male
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
        public void UpdateIsDeletedServiceById(ServiceDto service)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedServiceById,
                    new
                    { service.IsDeleted },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
