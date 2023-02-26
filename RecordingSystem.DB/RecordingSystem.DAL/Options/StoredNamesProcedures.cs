using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Options
{
    public class StoredNamesProcedures
    {
        public const string GetAllDoctors = "GetAllDoctors";
        public const string AddPatient = "AddPatient";
        public const string GettAllPatients = "GetAllPatients";
        public const string AddCabinet = "AddCabinet";
        public const string AddService = "AddService";
        public const string AddTimeSpan = "AddTimeSpan";
        public const string GetAllSpecializations = "GetAllSpecializations";
        public const string GetAllCabinets = "GetAllCabinets";
        public const string UpdatePatientById = "UpdatePatientById";
        public const string AddDoctor = "AddDoctor";
        public const string AddSpecialization = "AddSpecialization";
        public const string UpdateCabinetById = "UpdateCabinetById";
        public const string UpdateDoctorById = "UpdateDoctorById";
        public const string GetAllServiceByMale = "GetAllServiceByMale";
        public const string UpdateServiceById = "UpdateServiceById";
        public const string UpdateIsDeletedDoctorById = "UpdateIsDeletedDoctorById";
        public const string UpdateIsDeletedPatientById = "UpdateIsDeletedPatientById";
        public const string UpdateIsDeletedServiceById = "UpdateIsDeletedServiceById";
        public const string AddActiveRecording = "AddActiveRecording";
        public const string UpdateComingInActiveRecordingById = "UpdateComingInActiveRecordingById";
        public const string UpdateIsDeletedActiveRecordingById = "UpdateIsDeletedActiveRecordingById";
        public const string GetAllPatientsByStatusId = "GetAllPatientsByStatusId";
        public const string GetAllServiceByDoctorId = "GetAllServiceByDoctorId";
        public const string GetAllDoctorsByServiceId = "GetAllDoctorsByServiceId";
        public const string GetTimeTableByDoctorId = "GetTimeTableByDoctorId";
        public const string GetAllDoctorBySpecializationId = "GetAllDoctorBySpecializationId";
        public const string GetAllActiveRecordingsByPatientId = "GetAllActiveRecordingsByPatientId";
        public const string GetAllFreeDoctorsByDayOfWeekId = "GetAllFreeDoctorsByDayOfWeekId";
        public const string GetAllStatuses = "GetAllStatuses";
        public const string UpdateStatusById = "UpdateStatusById";
        public const string GetAllTimeRecordingsByDoctorId = "GetAllTimeRecordingsByDoctorId";
        public const string AddTimeRecording = "AddTimeRecording";
        public const string UpdateTimeRecordingById = "UpdateTimeRecordingById"; 
        public const string GetAllServiceBySpecializationId = "GetAllServiceBySpecializationId"; 
        public const string AddDiagnosis = "AddDiagnosis"; 
        public const string AddRecordingHistory = "AddRecordingHistory"; 
        public const string GetRecordingHistoryByPatientId = "GetRecordingHistoryByPatientId"; 
        public const string AddTimeTable = "AddTimeTable"; 
        public const string GetAllTimeSpan = "GetAllTimeSpan"; 
        public const string GetAllDayOfWeek = "GetAllDayOfWeek"; 
        public const string AddDayOfWeek = "AddDayOfWeek"; 
        public const string GetAllTimeRecording = "GetAllTimeRecording";
    }
}
