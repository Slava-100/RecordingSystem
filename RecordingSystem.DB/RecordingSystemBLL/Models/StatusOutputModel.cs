using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class StatusOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Discount { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is StatusOutputModel model &&
                   Id == model.Id &&
                   Name == model.Name &&
                   Discount == model.Discount;
        }
    }
}
