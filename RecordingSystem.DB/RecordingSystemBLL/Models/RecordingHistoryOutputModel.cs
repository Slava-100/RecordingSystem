using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
    public class RecordingHistoryOutputModel
    {
        public int Id { get; set; }
        public ActiveRecordingDto ActiveRecording { get; set; }
        public DiagnosisDto Diagnosis { get; set; }
    }
}
