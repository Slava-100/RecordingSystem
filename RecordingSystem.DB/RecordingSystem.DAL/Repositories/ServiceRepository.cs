using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using System.Data;
using RecordingSystem.DAL.Options;


namespace RecordingSystem.DAL.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        public void AddService(ServiceDto serviceDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddService,
                    new { serviceDto.Name, serviceDto.Price, serviceDto.SpecializationId, serviceDto.Male },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateServiceById(ServiceDto service)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedServiceById,
                    new
                    { service.IsDeleted },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<ServiceDto> GetAllServicesByDoctorId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                
                sqlConnection.Open();
              var result = sqlConnection.Query< DoctorDto, ServiceDto, ServiceDto > (StoredNamesProcedures.GetAllServiceByDoctorId,
                    (doctor,service) =>
                    {

                        return service;
                    },
                    new { Id_doctor = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public List<ServiceDto> GetAllServiceByMale(bool? male)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                var result = new List<ServiceDto>();

                sqlConnection.Open();
                sqlConnection.Query<ServiceDto, SpecializationDto, ServiceDto>(StoredNamesProcedures.GetAllServiceByMale,
                    (service, specialization) =>
                    {
                        result.Add(service);
                        service.Specialization = specialization;

                        return service;
                    },
                    new { Male = male },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
