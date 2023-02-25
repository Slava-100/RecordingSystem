using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class DayOfWeekOutputModel
    {
        public int Id { get; set; }
        public DateTime Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is DayOfWeekOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name;
        }
    }
}
