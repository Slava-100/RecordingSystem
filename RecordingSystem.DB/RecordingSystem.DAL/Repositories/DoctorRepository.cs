using Dapper;
using Microsoft.Data.SqlClient;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Options;
using System.Data;

namespace RecordingSystem.DAL.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        public List<DoctorDto> GetAllDoctors()
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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

        public void AddDoctor(DoctorDto doctorDto)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.AddDoctor,
                    new { doctorDto.Name, doctorDto.LastName, doctorDto.Male, doctorDto.PhoneNumber, doctorDto.Email, doctorDto.SpecializationId, doctorDto.CabinetId, doctorDto.Birthday },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateDoctor(DoctorDto doctor)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
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
                        doctor.Birthday
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateIsDeletedDoctorById(DoctorDto doctor)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                sqlConnection.Open();

                sqlConnection.Execute(StoredNamesProcedures.UpdateIsDeletedDoctorById,
                    new { doctor.IsDeleted },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public List<DoctorDto> GetAllDoctorsByServiceId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                List<DoctorDto> result = new List<DoctorDto>();

                sqlConnection.Open();
                sqlConnection.Query<ServiceDto, DoctorDto, DoctorDto>(
                    StoredNamesProcedures.GetAllDoctorsByServiceId,
                    (service, doctor) =>
                    {
                        doctor.Services.Add(service);
                        result.Add(doctor);
    
                        return doctor;
                    },
                    new { Id_Services = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public List<DoctorDto> GetAllDoctorBySpecializationId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                List<DoctorDto> result = new List<DoctorDto>();

                sqlConnection.Open();
                sqlConnection.Query<SpecializationDto, DoctorDto, DoctorDto>(
                    StoredNamesProcedures.GetAllDoctorBySpecializationId,
                    (specialization, doctor) =>
                    {
                        doctor.Specialization = specialization;
                        result.Add(doctor);

                        return doctor;
                    },
                    new { Id_Specialization = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public List<DoctorDto> GetAllFreeDoctorsByDayOfWeekId(int id)
        {
            using (var sqlConnection = new SqlConnection(Сonnection.sqlConnection))
            {
                TimeTableDto timeTable = new TimeTableDto();
                List<DoctorDto> result = new List<DoctorDto>();

                sqlConnection.Open();
                sqlConnection.Query<DayOfWeekDto, DoctorDto, TimeSpanDto, TimeRecordingDto, DoctorDto >(StoredNamesProcedures.GetAllFreeDoctorsByDayOfWeekId,
                    (dayOfWeek, doctor, timeSpan, timeRecording) =>
                    {
                        timeTable.DayOfWeek = dayOfWeek;
                        timeTable.TimeSpan = timeSpan;
                        timeRecording.TimeTable = timeTable;

                        DoctorDto crnt = null;
                        if (result.Any(d => d.Id == doctor.Id))
                        {
                            crnt = result.Find(d => d.Id == doctor.Id);
                        }
                        else
                        {
                            crnt = doctor;
                            result.Add(crnt);
                        }

                        crnt.TimeRecording.Add(timeRecording);

                        return crnt;
                    },
                    new { Id_DayOfWeek = id },
                    splitOn: "Id",
                    commandType: CommandType.StoredProcedure).ToList();

                return result;
            }
        }
    }
}
