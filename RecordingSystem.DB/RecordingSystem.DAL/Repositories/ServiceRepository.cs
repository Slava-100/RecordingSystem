using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
using System.Data;
using System.Numerics;


namespace RecordingSystem.DAL.Repositories
{
    public class ServiceRepository : IServiceRepository
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

        public DoctorDto GetAllDoctorInfoById(int Id_doctor)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                DoctorDto result = null;
                
                sqlConnection.Open();
                sqlConnection.Query< DoctorDto, ServiceDto, DoctorDto > (StoredNamesProcedures.GetAllServiceByDoctorId,
                    (doctor,service) =>
                    {
                        if (result is null)
                        {
                            result = doctor;
                        }

                        result.Services.Add(service);

                        return doctor;
                    },
                    new { Id_doctor },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public List<ServiceDto> GetAllServiceByMale(bool? Male)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
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
                    new { Male },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
