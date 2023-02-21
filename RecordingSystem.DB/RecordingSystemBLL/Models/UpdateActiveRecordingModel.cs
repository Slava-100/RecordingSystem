using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class UpdateActiveRecordingModel
    {
        public int? Id { get; set; }
        public bool? Coming { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UpdateActiveRecordingModel model &&
                   Id == model.Id &&
                   Coming == model.Coming;
        }
    }
}
