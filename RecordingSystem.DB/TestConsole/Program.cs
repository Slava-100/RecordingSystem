using RecordingSystem.DAL.Repositories;
using RecordingSystem.BLL;
using RecordingSystem.DAL.Models;

//DateTime someDate = new DateTime(2001, 01, 01);
//Console.WriteLine(someDate);

//var d = new PatientRepository();
//var patient = new PatientDto() { Name = "Gosha", LastName = "Str", PhoneNumber = "123-123", Email = "@", Status = null, Male = true, Birthday = someDate };
//d.AddPatient(patient);

//var ppp = d.GetAllPatients();

//ppp[ppp.Count - 1].IsDeleted = true;

//d.UpdateIsDeletedPatientById(ppp[ppp.Count - 1]);

//var p = new ActiveRecordingRepository();
//var ppp = p.GetAllActiveRecordingsByPatientId(6);

//var pppp = ppp[0];
//pppp.Coming = false;

//p.UpdateComingInActiveRecordingById(pppp);


//var p = new ActiveRecordingRepository();
//var ppp = p.GetAllActiveRecordingsByPatientId(6);




//var pppp = ppp[0];
//pppp.Name = "Kavkaz";
//p.UpdateDoctor(ppp[0]);


//var p = new DoctorRepository();
//var ppp = p.GetAllDoctors();

//var p = new ServiceRepository();
//var ppp = p.GetAllServiceByMale(null);

//var d = new DoctorRepository();

//var ppp = d.GetAllDoctors();

//var p = new RecordingHistoryRepository();    
//var pp = p.GetRecordingHistoryByPatientId(5);


//ppp[1].Name = "qqqqqqqqqq";

//d.UpdateDoctor(ppp[1]);

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
//var ppp = p.GetAllDoctorBySpecializationId(3);
//var p = new DoctorRepository();
//var ppp = p.GetAllDoctorBySpecializationId(1);

//var p = new TimeTableRepository();
//var ppp = p.GetTimeTableByDoctorId(11);

//var p = new DoctorRepository();
//var ppp = p.GetAllFreeDoctorsByDayOfWeekId(3);
//var p = new RecordingHistoryRepository();
//var ppp = p.GetRecordingHistoryByPatientId(5);

//var m = new ServiceManager();
//var qqq = m.GetAllDoctorInfoById(14);

//var m = new StatusRepository();
//var qqq = m.GetAllStatuses();
//var m = new CabinetManager();
//var qqq = m.GetAllCabinets();

//var a = new StatusDto();
//a.Id = 1;
//a.Discount = 69;
//m.UpdateStatusById(a);


//var a = new TimeRecordingRepository();
//var b = a.GetAllTimeRecordings();
//var b = new TimeRecordingDto();
//b.TimeTableId = 28;
//b.Occupied = true;
//a.AddTimeRecording(b);

//var a = new ServiceRepository();

//var b = a.GetAllServiceBySpecializationId(3);

//var patient = new PatientRepository();
//var ppp = patient.GetAllPatients(); 



var patient = new PatientRepository();

var p = new PatientManager(patient);

var ppp = p.GetAllPatientsByStatusId(2);

//var p = new TimeRecordingRepository();

//var ppp = p.GetAllTimeRecordings();

//var d = new DoctorRepository();

//var ppp = d.GetAllDoctors();


Console.WriteLine("qwe");


