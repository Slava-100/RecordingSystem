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

            if (obj is DoctorDto)
            {
                List<ServiceDto> sd = ((DoctorDto)obj).Services;
                if (sd.Count != Services.Count)
                {
                    return false;
                }
                for (int i = 0; i < Services.Count; i++)
                {
                    if (Services[i] != sd[i])
                    {
                        return false;
                    }
                }

                List<TimeRecordingDto> tr = ((DoctorDto)obj).TimeRecording;
                if (tr.Count != TimeRecording.Count)
                {
                    return false;
                }
                for (int i = 0; i < TimeRecording.Count; i++)
                {
                    if (TimeRecording[i] != tr[i])
                    {
                        return false;
                    }
                }
            }

            return obj is DoctorOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   LastName == model.LastName &&
                   Male == model.Male &&
                   PhoneNumber == model.PhoneNumber &&
                   Email == model.Email &&
                   Birthday == model.Birthday &&
                   Specialization.Equals(model.Specialization) &&
                   Cabinet.Equals(model.Cabinet);
        }
    }
}
