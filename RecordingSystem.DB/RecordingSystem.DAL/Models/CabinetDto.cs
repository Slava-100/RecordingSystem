using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class CabinetDto
    {
        public int CabinetId { get; set; }
        public int CabinetNumber { get; set; }
        public bool? Status { get; set; }
    }
}
