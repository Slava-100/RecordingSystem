using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL.Models
{
    public class DoctorInputModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool? Male { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? SpecializationId { get; set; }
        public int? CabinetId { get; set; }
        public DateTime? Birthday { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DoctorInputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   LastName == model.LastName &&
                   Male == model.Male &&
                   PhoneNumber == model.PhoneNumber &&
                   Email == model.Email &&
                   SpecializationId == model.SpecializationId &&
                   CabinetId == model.CabinetId &&
                   Birthday == model.Birthday;
        }
    }
}
