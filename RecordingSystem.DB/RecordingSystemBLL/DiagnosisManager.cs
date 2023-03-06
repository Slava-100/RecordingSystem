using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
    public class DiagnosisManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public IDiagnosRepository DiagnosRepository { get; set; }

        public DiagnosisManager()
        {
            DiagnosRepository = new DiagnosRepository();
        }

        public void AddDiagnosis(DiagnosisInputModel diagnosis)
        {
            var diagnosisDto = _mapperrr.MapDiagnosisInputModelToDiagnosisDto(diagnosis);
            DiagnosRepository.AddDiagnosis(diagnosisDto.Name, diagnosisDto.Recommendations);
        }

        public List<DiagnosisOutputModel> GetAllDiagnosis()
        {
            var diagnoses = DiagnosRepository.GetAllDiagnosis();
            var result = _mapperrr.MapListDiagnosisDtoToListDiagnosisOutputModel(diagnoses);

            return result;
        }
    }
}
