namespace RecordingSystem.BLL.Models
{
    public class ServiceInputModel
    {
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? SpecializationId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Male { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ServiceInputModel model &&
                   Name == model.Name &&
                   Price == model.Price &&
                   SpecializationId == model.SpecializationId &&
                   IsDeleted == model.IsDeleted &&
                   Male == model.Male;
        }
    }
}
