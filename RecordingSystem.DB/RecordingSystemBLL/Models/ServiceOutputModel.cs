using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class ServiceOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? SpecializationId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Male { get; set; }
        public SpecializationOutputModel Specialization { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ServiceOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   Price == model.Price &&
                   SpecializationId == model.SpecializationId &&
                   IsDeleted == model.IsDeleted &&
                   Male == model.Male &&
                   Specialization.Equals(model.Specialization);
        }
    }
}
