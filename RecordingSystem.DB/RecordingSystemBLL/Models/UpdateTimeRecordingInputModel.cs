using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class UpdateTimeRecordingInputModel
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int TimeTableId { get; set; }
        public bool? Occupied { get; set; }
    }
}
