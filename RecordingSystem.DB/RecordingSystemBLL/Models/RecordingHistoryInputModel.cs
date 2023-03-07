using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class RecordingHistoryInputModel
    {
        public int DiagnosisId { get; set; }
        public int ActiveRecordingId { get; set; }
    }
}
