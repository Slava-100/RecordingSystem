using RecordingSystem.DAL.Repositories;

//DateTime someDate = new DateTime(2001,01,01);
//Console.WriteLine(someDate);

//var d = new PatientRepository();
//d.AddPatient("Vova", "Str", "123-123", "@", null, true, someDate);


//var p = new DoctorRepository();
//var ppp = p.GetAllDoctors();

var p = new PatientRepository();
var ppp = p.GetAllPatientsByStatusId(3);

Console.WriteLine("qwe");
