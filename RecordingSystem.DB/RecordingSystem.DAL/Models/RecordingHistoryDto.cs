using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Models
{
    public class RecordingHistoryDto
    {
        public int Id { get; set; }
        public int DiagnosisId { get; set; }
        public int ActiveRecordingId { get; set; }
        public ActiveRecordingDto ActiveRecording { get; set;}
        public DiagnosisDto Diagnosis { get; set; }

    }
}
