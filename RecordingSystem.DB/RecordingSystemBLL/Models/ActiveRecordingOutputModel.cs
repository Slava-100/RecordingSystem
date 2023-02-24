using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class ActiveRecordingOutputModel
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? Coming { get; set; }
        public PatientOutputModel Patient { get; set; }
        public DoctorOutputModel Doctor { get; set; }
        public CabinetOutputModel Cabinet { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ActiveRecordingOutputModel model &&
                   Id == model.Id &&
                   PatientId == model.PatientId &&
                   DoctorId == model.DoctorId &&
                   DateTime == model.DateTime &&
                   Coming == model.Coming &&
                   Patient.Equals(model.Patient) &&
                   Cabinet.Equals(model.Cabinet) &&
                   Doctor.Equals(model.Doctor);
        }
    }
}
