using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
    public class RecordingHistoryManager
    {
        private Mapperrr _mapperrr = new Mapperrr();
        public IRecordingHistoryRepository RecordingHistoryRepository { get; set; }

        public RecordingHistoryManager()
        {
            RecordingHistoryRepository = new RecordingHistoryRepository();
        }

        public void AddRecordingHistory(RecordingHistoryInputModel recordingHistory)
        {
            var recordingHistoryDto = _mapperrr.MapRecordingHistoryInputModelToRecordingHistoryDto(recordingHistory);
            RecordingHistoryRepository.AddRecordingHistory(recordingHistoryDto.DiagnosisId, recordingHistoryDto.ActiveRecordingId);
        }

        public List<RecordingHistoryOutputModel> GetRecordingHistoryByPatientId(int id)
        {
            var recordingHistory = RecordingHistoryRepository.GetRecordingHistoryByPatientId(id);
            var result = _mapperrr.MapListRecordingHistoryDtotoListRecordingHistoryOutputModel(recordingHistory);
            return result;
        }

        public RecordingHistoryOutputModel GetRecordingHistoryById(int id)
        {
            var recordingHistory = RecordingHistoryRepository.GetRecordingHistoryById(id);
            var result = _mapperrr.MapRecordingHistoryDtotoRecordingHistoryOutputModel(recordingHistory);
            return result;
        }
    }
}
