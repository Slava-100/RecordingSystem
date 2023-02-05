using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class StatusDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Discount { get; set; }
    }
}
