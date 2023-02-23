using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class TimeRecordingInputModel
    {
        public DateTime? Date { get; set; }
        public int TimeTableId { get; set; }
        public bool Occupied { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimeRecordingInputModel model &&
                   Date == model.Date &&
                   TimeTableId == model.TimeTableId &&
                   Occupied == model.Occupied;
        }
    }
}
