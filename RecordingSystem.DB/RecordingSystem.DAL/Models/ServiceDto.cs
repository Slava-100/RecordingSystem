using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public int? SpecializationId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Male { get; set; }
        public SpecializationDto Specialization { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is ServiceDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name &&
                   Price == dto.Price &&
                   SpecializationId == dto.SpecializationId &&
                   IsDeleted == dto.IsDeleted &&
                   Male == dto.Male &&
                   Specialization.Equals(dto.Specialization);
        }
    }
}
