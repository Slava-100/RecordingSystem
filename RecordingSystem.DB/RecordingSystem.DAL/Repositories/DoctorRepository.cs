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
                return sqlConnection.Query<DoctorDto, SpecializationDto, CabinetDto, DoctorDto>(StoredNamesProcedures.GetAllDoctors,
                    (doctor, specialization, cabinet) =>
                    {
                        doctor.Specialization = specialization;
                        doctor.Cabinet = cabinet;

                        return doctor;
                    },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void AddDoctor(string name, string lastName, bool male, string phoneNumber,
            string email, int? specializationId, int? cabinetId, DateTime birthday)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddDoctor,
                    new { name, lastName, male, phoneNumber, email, specializationId, cabinetId, birthday },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateDoctor(DoctorDto doctor)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateDoctortById,
                    new
                    {
                        doctor.Id,
                        doctor.Name,
                        doctor.LastName,
                        doctor.Male,
                        doctor.PhoneNumber,
                        doctor.Email,
                        doctor.SpecializationId,
                        doctor.CabinetId,
                        doctor.Birthday,
                        doctor.IsDeleted
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<ServiceDto> GetAllDoctorsByServiceId(int Id_service)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<ServiceDto> result = null;

                sqlConnection.Open();
                sqlConnection.Query<ServiceDto, DoctorDto, ServiceDto>(StoredNamesProcedures.GetAllDoctorsByServiceId,
                    (service, doctor) =>
                    {
                        foreach (var a in result)
                        {
                            if (a.Id == Id_service)
                            {
                                service.Doctors.Add(doctor);
                            }
                            else
                            {
                                result.Add(service);
                            }
                        }

                        return service;
                    },
                    new { Id_service },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
    }
}
