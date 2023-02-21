using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class CabinetDto
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public bool? Status { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is CabinetDto dto &&
                   Id == dto.Id &&
                   Number == dto.Number &&
                   Status == dto.Status;
        }
    }
}
