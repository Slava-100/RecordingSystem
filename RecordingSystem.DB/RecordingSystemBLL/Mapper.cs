using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Models;

namespace RecordingSystem.BLL
{
    public class Mapperrr
    {
        private MapperConfiguration _configuration;

        public Mapperrr()
        {
            _configuration = new MapperConfiguration(
                cfg =>
                {
                cfg.CreateMap<ServiceDto, ServiceOutputModel>();
                cfg.CreateMap<PatientDto, PatientOutputModel>();
                });
        }

        public List<ServiceOutputModel> MapServiceDtoToServiceOutputModel(List<ServiceDto> service)
        {
            return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(service);
        }

        public List<PatientOutputModel> MapListPatientDtoToListPatientOutputModel(List<PatientDto> patients)
        {
            return _configuration.CreateMapper().Map<List<PatientOutputModel>>(patients);
        }

        public List<PatientOutputModel> MapListPatientDtoToListPatientOutputModelByStatusId(List<PatientDto> patients)
        {
            return _configuration.CreateMapper().Map<List<PatientOutputModel>>(patients);
        }

    }
}
