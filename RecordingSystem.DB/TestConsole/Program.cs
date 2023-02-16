using RecordingSystem.DAL.Repositories;
using RecordingSystem.BLL;
using RecordingSystem.DAL.Models;

//DateTime someDate = new DateTime(2001,01,01);
//Console.WriteLine(someDate);

//var d = new PatientRepository();
//d.AddPatient("Vova", "Str", "123-123", "@", null, true, someDate);

//var p = new ActiveRecordingRepository();
//var ppp = p.GetAllActiveRecordingsByPatientId(6);

//var p = new ActiveRecordingRepository();
//var ppp = p.GetAllActiveRecordingsByPatientId(6);

//var p = new DoctorRepository();
//var ppp = p.GetAllDoctorsByServiceId(14);

//var p = new DoctorRepository();
//var ppp = p.GetAllDoctorsByServiceId(14);
//var p = new DoctorRepository();
//var ppp = p.GetAllDoctors();

//var p = new ServiceRepository();
//var ppp = p.GetAllServicesByDoctorId(11);

//var p = new ServiceRepository();
//var ppp = p.GetAllServicesByDoctorId(11);
//var p = new PatientRepository();
//var ppp = p.GetAllPatientsByStatusId(3);
//var p = new ServiceRepository();
//var ppp = p.GetAllServiceByMale(null);

//var p = new TimeTableRepository();
//var ppp = p.GetTimeTableByDoctorId(11);
//var p = new PatientRepository();
//var ppp = p.GetAllPatientsByStatusId(3);

//var p = new DoctorRepository();
//var ppp = p.GetAllDoctorBySpecializationId(1);

//var p = new TimeTableRepository();
//var ppp = p.GetTimeTableByDoctorId(11);

//var p = new DoctorRepository();
//var ppp = p.GetAllFreeDoctorsByDayOfWeekId(3);

//var m = new ServiceManager();
//var qqq = m.GetAllDoctorInfoById(14);

var m = new StatusRepository();
//var qqq = m.GetAllStatuses();

var a = new StatusDto();
a.Id = 1;
a.Discount = 69;
m.UpdateStatusById(a);

Console.WriteLine("qwe");
