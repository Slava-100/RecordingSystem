using RecordingSystem.DAL.Repositories;


//TimeSpan time1 = new TimeSpan(14, 2, 8);
Console.WriteLine("start");

var p = new CabinetRepository();
var ppp = p.GetAllCabinets();

Console.WriteLine(ppp[0].Number);

//var d = new TimeSpanRepository();
//d.AddTimeSpan(time1, time1);


//var p = new PatientRepository();
//var ppp = p.GetAllPatients();



Console.WriteLine("qwe");
