using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class SpecializationInputModel
    {
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is SpecializationInputModel dto &&
                   Name == dto.Name;
        }
    }
}
