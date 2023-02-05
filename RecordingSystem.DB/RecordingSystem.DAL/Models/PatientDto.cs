using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class PatientDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? StatusId { get; set; }
        public bool Male { get; set; }
        public bool IsDeleted { get; set; }
        public StatusDto Status { get; set; }
    }
}
