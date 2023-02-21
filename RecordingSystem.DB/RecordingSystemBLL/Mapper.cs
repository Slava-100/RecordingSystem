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
                cfg.CreateMap<ServiceInputModel, ServiceDto>();
                cfg.CreateMap<UpdateServiceInputModel, ServiceDto>();
                cfg.CreateMap<CabinetDto, CabinetOutputModel>();
                cfg.CreateMap<CabinetInputModel, CabinetDto>();
                cfg.CreateMap<UpdateCabinetInputModel, CabinetDto>();
                cfg.CreateMap<SpecializationDto,SpecializationOutputModel>();
                cfg.CreateMap<SpecializationInputModel, SpecializationDto>();
                cfg.CreateMap<TimeRecordingDto, TimeRecordingOutputModel>();
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
        public DoctorDto MapDoctorInputModelToDoctorDto(DoctorInputModel doctor)
        {
            return _configuration.CreateMapper().Map<DoctorDto>(doctor);
        }
           

        public List<ActiveRecordingOutputModel> MapListActiveRecordingDtotoListActiveRecordingOutputModel(List<ActiveRecordingDto> activeRecordings)
        {
            return _configuration.CreateMapper().Map<List<ActiveRecordingOutputModel>>(activeRecordings);
        }
        public List<CabinetOutputModel> MapListCabinetDtoToListCabinetOutputModel(List<CabinetDto> cabinets)
        {
            return _configuration.CreateMapper().Map<List<CabinetOutputModel>>(cabinets);
        }

        public ActiveRecordingDto MapUpdateActiveRecordingModelToActiveRecordingDto(UpdateActiveRecordingModel activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingDto>(activeRecording);
        }
        public ActiveRecordingDto MapActiveRecordingInputModelToActiveRecordingDto(ActiveRecordingInputModel activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingDto>(activeRecording);
        }

        public CabinetDto MapCabinetInputModelToCabinetDto(CabinetInputModel cabinet)
        {
            return _configuration.CreateMapper().Map<CabinetDto>(cabinet);
        }
        public CabinetDto MapUpdateCabinetInputModelToCabinetDto(UpdateCabinetInputModel cabinet)
        {
            return _configuration.CreateMapper().Map<CabinetDto>(cabinet);
        }
        public ServiceDto MapServiceInputModelToServiceDto(ServiceInputModel service)
        {
            return _configuration.CreateMapper().Map<ServiceDto>(service);
        }

        public ServiceDto MapUpdateServiceInputModelToServiceDto(UpdateServiceInputModel service)
        {
            return _configuration.CreateMapper().Map<ServiceDto>(service);
        }

        public List<ServiceOutputModel> MapListServiceDtoToListServiceOutputModel(List<ServiceDto> services)
        {
            return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(services);
        }

        public List<SpecializationOutputModel> MapListSpecializationDtoToListSpecializationOutputModel(List<SpecializationDto> specializations)
        {
            return _configuration.CreateMapper().Map<List<SpecializationOutputModel>>(specializations);
        }

        public SpecializationDto MapSpecializationInputModelToSpecializationDto(SpecializationInputModel specialization)
        {
            return _configuration.CreateMapper().Map<SpecializationDto>(specialization);
        }

        public List<TimeRecordingOutputModel> MapListTimeRecordingDtoToListTimeRecordingOutputModel(List<TimeRecordingDto> timeRecordings)
        {
            return _configuration.CreateMapper().Map<List<TimeRecordingOutputModel>>(timeRecordings);
        }
    }
}
