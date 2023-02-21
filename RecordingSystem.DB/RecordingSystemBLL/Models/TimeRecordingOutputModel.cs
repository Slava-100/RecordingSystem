using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class TimeRecordingOutputModel
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int TimeTableId { get; set; }
        public bool? Occupied { get; set; }
        public TimeTableDto TimeTable { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimeRecordingOutputModel model &&
                   Id == model.Id &&
                   Date == model.Date &&
                   TimeTableId == model.TimeTableId &&
                   Occupied == model.Occupied &&
                   TimeTable.Equals(model.TimeTable);
        }
    }
}
