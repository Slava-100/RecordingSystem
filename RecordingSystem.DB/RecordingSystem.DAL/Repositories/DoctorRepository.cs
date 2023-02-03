﻿using RecordingSystem.DAL.Models;
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
    }
}
