using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class ActiveRecordingDto
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public DateTime? DateTime { get; set; }
        public bool? Coming { get; set; }
        public bool? IsDeleted { get; set; }
        public PatientDto Patient { get; set; }
        public DoctorDto Doctor { get; set; }

    }
}
