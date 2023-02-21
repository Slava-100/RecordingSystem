using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool? Male { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? SpecializationId { get; set; }
        public int? CabinetId { get; set;}
        public bool? IsDeleted { get; set; }
        public DateTime? Birthday { get; set; }
        public SpecializationDto Specialization { get; set; }
        public CabinetDto Cabinet { get; set; }
        public List<ServiceDto> Services { get; set; } = new List<ServiceDto>();
        public List<TimeRecordingDto> TimeRecording { get; set; } = new List<TimeRecordingDto>();

        public override bool Equals(object? obj)
        {
            if (obj is DoctorDto)
            {
                List<ServiceDto> sd = ((DoctorDto)obj).Services;
                if (sd.Count != Services.Count)
                {
                    return false;
                }
                for (int i = 0; i < Services.Count; i++)
                {
                    if (Services[i] != sd[i])
                    {
                        return false;
                    }
                }

                List<TimeRecordingDto> tr = ((DoctorDto)obj).TimeRecording;
                if (tr.Count != TimeRecording.Count)
                {
                    return false;
                }
                for (int i = 0; i < TimeRecording.Count; i++)
                {
                    if (TimeRecording[i] != tr[i])
                    {
                        return false;
                    }
                }
            }


            return obj is DoctorDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name &&
                   LastName == dto.LastName &&
                   Male == dto.Male &&
                   PhoneNumber == dto.PhoneNumber &&
                   Email == dto.Email &&
                   SpecializationId == dto.SpecializationId &&
                   CabinetId == dto.CabinetId &&
                   IsDeleted == dto.IsDeleted &&
                   Birthday == dto.Birthday &&
                   Specialization.Equals(dto.Specialization) &&
                   Cabinet.Equals(dto.Cabinet);

        }
    }
}
