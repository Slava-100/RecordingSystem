using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Models;
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
        public List<ServiceDto> GetAllDoctorsByServiceId(int id)
        {
            using (var sqlConnection = new SqlConnection(Options.sqlConnection))
            {
                List<ServiceDto> result = new List<ServiceDto>();

                sqlConnection.Open();
                sqlConnection.Query<ServiceDto, DoctorDto, ServiceDto>(
                    StoredNamesProcedures.GetAllDoctorsByServiceId,
                    (service, doctor) =>
                    {
                        ServiceDto crnt = null;

                        if (result.Any(s => s.Id == service.Id))
                        {
                            crnt = result.Find(s => s.Id == service.Id);
                        }
                        else
                        {
                            crnt = service;
                            result.Add(crnt);
                        }

                        //crnt.Doctors.Add(doctor);
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
