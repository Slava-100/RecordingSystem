using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class DoctorOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool? Male { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public SpecializationDto Specialization { get; set; }
        public CabinetDto Cabinet { get; set; }
        public List<ServiceDto> Services { get; set; } = new List<ServiceDto>();
        public List<TimeRecordingDto> TimeRecording { get; set; } = new List<TimeRecordingDto>();

        public override bool Equals(object? obj)
        {
            return obj is DoctorOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   LastName == model.LastName &&
                   Male == model.Male &&
                   PhoneNumber == model.PhoneNumber &&
                   Email == model.Email &&
                   Birthday == model.Birthday &&
                   Specialization.Equals(model.Specialization) &&
                   Cabinet.Equals(model.Cabinet) &&
                   Services.Equals(model.Services) &&
                   TimeRecording.Equals(model.TimeRecording);
        }
    }
}
