using RecordingSystem.DAL.Repositories;

//DateTime someDate = new DateTime(2001,01,01);
//Console.WriteLine(someDate);

//var d = new PatientRepository();
//d.AddPatient("Vova", "Str", "123-123", "@", null, true, someDate);


var p = new ServiceRepository();
var ppp = p.GetAllServicesByDoctorId(11);



Console.WriteLine("qwe");
