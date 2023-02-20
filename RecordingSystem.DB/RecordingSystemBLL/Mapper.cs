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
                cfg.CreateMap<DoctorDto, DoctorOutputModel>();
                cfg.CreateMap<PatientInputModel, PatientDto>();
                cfg.CreateMap<ActiveRecordingDto, ActiveRecordingOutputModel>()
                .ForMember(outputModel => outputModel.Cabinet, opt => opt.MapFrom(activeRecordingDto => activeRecordingDto.Doctor.Cabinet));
                cfg.CreateMap<ActiveRecordingInputModel, ActiveRecordingDto>();
                cfg.CreateMap<UpdateActiveRecordingModel, ActiveRecordingDto>();
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

        public PatientDto MapPatientInputModelToPatientDto(PatientInputModel patient)
        {
            return _configuration.CreateMapper().Map<PatientDto>(patient);
        }

        public PatientDto MapUpdatePatientInputModelToPatientDto(PatientInputModel patient)
        {
            return _configuration.CreateMapper().Map<PatientDto>(patient);
        }

        public List<DoctorOutputModel> MapDoctorDtoToDoctorOutputModel(List<DoctorDto> doctors)
        {
            return _configuration.CreateMapper().Map<List<DoctorOutputModel>>(doctors);
        }

        public List<ActiveRecordingOutputModel> MapListActiveRecordingDtotoListActiveRecordingOutputModel(List<ActiveRecordingDto> activeRecordings)
        {
            return _configuration.CreateMapper().Map<List<ActiveRecordingOutputModel>>(activeRecordings);
        }

        public ActiveRecordingDto MapUpdateActiveRecordingModelToActiveRecordingDto(UpdateActiveRecordingModel activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingDto>(activeRecording);
        }
        public ActiveRecordingDto MapActiveRecordingInputModelToActiveRecordingDto(ActiveRecordingInputModel activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingDto>(activeRecording);
        }



    }
}
