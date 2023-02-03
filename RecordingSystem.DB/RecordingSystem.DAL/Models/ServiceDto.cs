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
        public float Price { get; set; }
        public int? SpecializationId { get; set; }
        public int IsDeleted { get; set; }
        public bool? Male { get; set; }
        
    }
}
