using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class SpecializationDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is SpecializationDto dto &&
                   Id == dto.Id &&
                   Name == dto.Name;
        }
    }
}
