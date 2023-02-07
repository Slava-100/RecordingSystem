using RecordingSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface ISpecializationRepository
    {
        public List<SpecializationDto> GetAllSpecializations();
        public void AddSpecialization(string name);
    }
}
