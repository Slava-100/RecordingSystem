using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface IServiceRepository
    {
        public void AddService(string name, float price, int? specializationId, bool? male);
        public void UpdateService(ServiceDto service);
        public void UpdateServiceById(ServiceDto service);
        public void UpdateIsDeletedServiceById(ServiceDto service);
        public DoctorDto GetAllDoctorInfoById(int Id_doctor);
    }
}
