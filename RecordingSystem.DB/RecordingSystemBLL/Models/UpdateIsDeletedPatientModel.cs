using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class UpdateIsDeletedPatientModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

    }
}
