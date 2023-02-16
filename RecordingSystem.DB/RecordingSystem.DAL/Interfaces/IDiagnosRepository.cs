using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Interfaces
{
    public interface IDiagnosRepository
    {
        public void AddDiagnosis(string name, string recommendations);
    }
}
