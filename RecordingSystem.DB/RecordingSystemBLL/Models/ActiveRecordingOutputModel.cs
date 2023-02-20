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
        public PatientDto Patient { get; set; }
        public DoctorDto Doctor { get; set; }
        public CabinetDto Cabinet { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ActiveRecordingOutputModel model &&
                   Id == model.Id &&
                   PatientId == model.PatientId &&
                   DoctorId == model.DoctorId &&
                   DateTime == model.DateTime &&
                   Coming == model.Coming &&
                   Patient.Equals(model.Patient) &&
                   Doctor.Equals(model.Doctor) &&
                   Cabinet.Equals(model.Cabinet);
        }
    }
}
