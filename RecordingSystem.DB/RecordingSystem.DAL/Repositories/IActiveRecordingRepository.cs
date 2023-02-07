using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface IActiveRecordingRepository
    {
        public void AddActiveRecording(int patientId, int doctorId, DateTime date);
        public void UpdateComingInActiveRecordingById(ActiveRecordingDto recording);
        public void UpdateIsDeletedActiveRecordingById(ActiveRecordingDto recording);
        public List<ActiveRecordingDto> GetAllActiveRecordingsByPatientId(int id);
    }
}
