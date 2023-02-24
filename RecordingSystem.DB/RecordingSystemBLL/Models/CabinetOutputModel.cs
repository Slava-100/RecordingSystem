namespace RecordingSystem.BLL.Models
{
    public class CabinetOutputModel
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public bool? Status { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CabinetOutputModel model &&
                  Id == model.Id &&
                  Number == model.Number &&
                  Status == model.Status;
        }
    }
}
