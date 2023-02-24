using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class CabinetInputModel
    {
        public int? Number { get; set; }
        public bool? Status { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CabinetInputModel model &&
                  Number == model.Number &&
                  Status == model.Status;
        }
    }
}
