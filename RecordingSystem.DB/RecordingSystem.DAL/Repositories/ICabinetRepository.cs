using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface ICabinetRepository
    {
        public void AddCabinet(int number, bool? status);
        public List<CabinetDto> GetAllCabinets();
        public void UpdateCabinetById(CabinetDto cabinet);
    }
}
