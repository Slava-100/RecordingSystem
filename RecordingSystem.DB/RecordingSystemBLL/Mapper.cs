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
                //.ForMember(outputModel => outputModel))
                cfg.CreateMap<PatientDto, PatientOutputModel>();
                });
        }

        public List<ServiceOutputModel> MapServiceDtoToProductOutputModel(List<ServiceDto> service)
        {
            return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(service);
        }

        public List<PatientOutputModel> MapPatientDtoToPatientOutputModel(List<PatientDto> patients)
        {
            return _configuration.CreateMapper().Map<List<PatientOutputModel>>(patients);
        }
    }
}
