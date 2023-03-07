using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class PatientOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? StatusId { get; set; }
        public bool? Male { get; set; }
        public StatusOutputModel Status { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is PatientOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   LastName == model.LastName &&
                   Birthday == model.Birthday &&
                   PhoneNumber == model.PhoneNumber &&
                   Email == model.Email &&
                   StatusId == model.StatusId &&
                   Male == model.Male &&
                   Status.Equals(model.Status);
        }
    }
}
