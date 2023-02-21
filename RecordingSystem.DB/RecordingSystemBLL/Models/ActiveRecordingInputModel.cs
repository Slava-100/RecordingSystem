using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class ActiveRecordingInputModel
    {
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? DateTime { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ActiveRecordingInputModel model &&
                   PatientId == model.PatientId &&
                   DoctorId == model.DoctorId &&
                   DateTime == model.DateTime;
        }   
    }
}
