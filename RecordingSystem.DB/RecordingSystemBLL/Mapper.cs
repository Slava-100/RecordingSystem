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
                cfg.CreateMap<DoctorInputModel, DoctorDto>();
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
                cfg.CreateMap<TimeRecordingInputModel, TimeRecordingDto>();
                cfg.CreateMap<UpdateTimeRecordingInputModel, TimeRecordingDto>();
                cfg.CreateMap<TimeTableDto, TimeTableOutputModel>();
                cfg.CreateMap<DayOfWeekDto, DayOfWeekOutputModel>();
                cfg.CreateMap<StatusDto, StatusOutputModel>();
                cfg.CreateMap<TimeSpanDto, TimeSpanOutputModel>();
                cfg.CreateMap<TimeTableInputModel, TimeTableDto>();
                cfg.CreateMap<UpdateIsDeletedActiveRecordingModel, ActiveRecordingDto>();
                cfg.CreateMap<DiagnosisInputModel, DiagnosisDto>();
                cfg.CreateMap<DiagnosisDto, DiagnosisOutputModel>();
                cfg.CreateMap<RecordingHistoryInputModel, RecordingHistoryDto>();
                cfg.CreateMap<RecordingHistoryDto, RecordingHistoryOutputModel>(); 
                cfg.CreateMap<UpdateTimeSpanInputModel, TimeSpanDto>();
			    cfg.CreateMap<TimeSpanInputModel, TimeSpanDto>(); 
				cfg.CreateMap<DayOfWeekDto, DayOfWeekOutputModel>();
                cfg.CreateMap<UpdateRecordingHistoryInputModel, RecordingHistoryDto>(); 
                });
        }

        public List<ServiceOutputModel> MapListServiceDtoToListServiceOutputModel(List<ServiceDto> services)
        {
            return _configuration.CreateMapper().Map<List<ServiceOutputModel>>(services);
        }

        public ServiceOutputModel MapServiceDtoToServiceOutputModel(ServiceDto services)
        {
            return _configuration.CreateMapper().Map<ServiceOutputModel>(services);
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

        public List<DoctorOutputModel> MapListDoctorDtoToListDoctorOutputModel(List<DoctorDto> doctors)
        {
            return _configuration.CreateMapper().Map<List<DoctorOutputModel>>(doctors);
        }
        public DoctorDto MapDoctorInputModelToDoctorDto(DoctorInputModel inputDoctor)
        {
            return _configuration.CreateMapper().Map<DoctorDto>(inputDoctor);
        }

        public List<ActiveRecordingOutputModel> MapListActiveRecordingDtotoListActiveRecordingOutputModel(List<ActiveRecordingDto> activeRecordings)
        {
            return _configuration.CreateMapper().Map<List<ActiveRecordingOutputModel>>(activeRecordings);
        }
        public ActiveRecordingDto MapUpdateIsDeletedActiveRecordingModelToActiveRecordingDto(UpdateIsDeletedActiveRecordingModel activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingDto>(activeRecording);
        }

        public ActiveRecordingOutputModel MapActiveRecordingDtotoActiveRecordingOutputModel(ActiveRecordingDto activeRecording)
        {
            return _configuration.CreateMapper().Map<ActiveRecordingOutputModel>(activeRecording);
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

        public TimeRecordingDto MapTimeRecordingInputModelToTimeRecordingDto(TimeRecordingInputModel timeRecording)
        {
            return _configuration.CreateMapper().Map<TimeRecordingDto>(timeRecording);
        }

        public TimeRecordingDto MapUpdateTimeRecordingInputModelToTimeRecordingDto(UpdateTimeRecordingInputModel timeRecording)
        {
            return _configuration.CreateMapper().Map<TimeRecordingDto>(timeRecording);
        }

        public List<TimeTableOutputModel> MapListTimeTableDtoToListTimeTableOutputModel(List<TimeTableDto> timeTables)
        {
            return _configuration.CreateMapper().Map<List<TimeTableOutputModel>>(timeTables);
        }

        public TimeTableDto MapTimeTableInputModelToTimeTableDto(TimeTableInputModel timeTable)
        {
            return _configuration.CreateMapper().Map<TimeTableDto>(timeTable);
        }

        public SpecializationOutputModel MapSpecializationDtoToSpecializationOutputModel(SpecializationDto specialization)
        {
            return _configuration.CreateMapper().Map<SpecializationOutputModel>(specialization);
        }

        public TimeRecordingOutputModel MapTimeRecordingDtoToTimeRecordingOutputModel(TimeRecordingDto timeRecording)
        {
            return _configuration.CreateMapper().Map<TimeRecordingOutputModel>(timeRecording);
        }

        public DoctorOutputModel MapDoctorDtoToDoctorOutputModel(DoctorDto doctor)
        {
            return _configuration.CreateMapper().Map<DoctorOutputModel>(doctor);
        }

        public DiagnosisDto MapDiagnosisInputModelToDiagnosisDto(DiagnosisInputModel diagnosis)
        {
            return _configuration.CreateMapper().Map<DiagnosisDto>(diagnosis);
        }

        public List<DiagnosisOutputModel> MapListDiagnosisDtoToListDiagnosisOutputModel(List<DiagnosisDto> diagnoses)
        {
            return _configuration.CreateMapper().Map<List<DiagnosisOutputModel>>(diagnoses);
        }

        public RecordingHistoryDto MapRecordingHistoryInputModelToRecordingHistoryDto(RecordingHistoryInputModel recordingHistory)
        {
            return _configuration.CreateMapper().Map<RecordingHistoryDto>(recordingHistory);
        }

        public List<RecordingHistoryOutputModel> MapListRecordingHistoryDtotoListRecordingHistoryOutputModel(List<RecordingHistoryDto> recordingHistories)
        {
            return _configuration.CreateMapper().Map<List<RecordingHistoryOutputModel>>(recordingHistories);
        }

        public RecordingHistoryOutputModel MapRecordingHistoryDtotoRecordingHistoryOutputModel(RecordingHistoryDto recordingHistory)
        {
            return _configuration.CreateMapper().Map<RecordingHistoryOutputModel>(recordingHistory);
        }

		public TimeSpanDto MapUpdateTimeSpanInputModelToTimeSpanDto(UpdateTimeSpanInputModel updateTimeSpanInputModel)
		{
			return _configuration.CreateMapper().Map<TimeSpanDto>(updateTimeSpanInputModel);
		}

		public List<TimeSpanOutputModel> MapListTimeSpanDtoToListTimeSpanOutputModel(List<TimeSpanDto> timeSpans)
		{
			return _configuration.CreateMapper().Map<List<TimeSpanOutputModel>>(timeSpans);
		}
		public TimeSpanDto MapTimeSpanInputModelToTimeSpanDto(TimeSpanInputModel timeSpan)
		{
			return _configuration.CreateMapper().Map<TimeSpanDto>(timeSpan);
		}

		public List<DayOfWeekOutputModel> MapListDayOfWeeksDtoToListDayOfWeeksOutputModel(List<DayOfWeekDto> dayOfWeekDto)
		{
			return _configuration.CreateMapper().Map<List<DayOfWeekOutputModel>>(dayOfWeekDto);
		}

        public RecordingHistoryDto MapUpdateRecordingHistoryInputModelToRecordingHistoryDto(UpdateRecordingHistoryInputModel updateRecordingHistoryInputModel)
        {
            return _configuration.CreateMapper().Map<RecordingHistoryDto>(updateRecordingHistoryInputModel);
        }
    }
}
