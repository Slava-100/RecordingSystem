using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class TimeSpanOutputModel
    {
        public int Id { get; set; }
        public TimeSpan? Start { get; set; }
        public TimeSpan? End { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is TimeSpanOutputModel model &&
                   Id == model.Id &&
                   Start == model.Start &&
                   End == model.End;
        }
    }
}
