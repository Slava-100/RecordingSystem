using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;

namespace RecordingSystem.BLL
{
    public class TimeRecordingManager
    {
        private DateTime dateTimeNow = DateTime.Now;
        private Mapperrr _mapperrr = new Mapperrr();
        public ITimeRecordingRepository TimeRecordingRepository { get; set; }
      
        public TimeRecordingManager()
        {
            TimeRecordingRepository = new TimeRecordingRepository();
        }

        public List<TimeRecordingOutputModel> GetAllTimeRecordingsByDoctorId(int id)
        {
            var timeRecordings = TimeRecordingRepository.GetAllTimeRecordingsByDoctorId(id);
            var result = _mapperrr.MapListTimeRecordingDtoToListTimeRecordingOutputModel(timeRecordings);
            return result;
        }

        public void AddTimeRecording(TimeRecordingInputModel timeRecording)
        {
            var timeRecordingDto = _mapperrr.MapTimeRecordingInputModelToTimeRecordingDto(timeRecording);
            TimeRecordingRepository.AddTimeRecording(timeRecordingDto);
        }

        public void UpdateTimeRecordingById(UpdateTimeRecordingInputModel timeRecording)
        {
            var timeRecordingDto = _mapperrr.MapUpdateTimeRecordingInputModelToTimeRecordingDto(timeRecording);
            TimeRecordingRepository.UpdateTimeRecordingById(timeRecordingDto);
        }

        public void FillAllTimeRecordingInForAOneDay(DateTime date)
        {
            IDoctorRepository DoctorRepository = new DoctorRepository();
            ITimeTableRepository TimeTableRepository = new TimeTableRepository();

            var listDoctors = DoctorRepository.GetAllDoctors();
            var listDays = TimeRecordingRepository.GetAllDaysInTimeRecording();

            foreach (var d in listDoctors)
            {
                if (TimeRecordingRepository.GetAllTimeRecordingsByDoctorId(d.Id).Count == 0 || !listDays.Any(d => d.Date == date))
                {
                    var crntListTimeTabelByDoctor = TimeTableRepository.GetTimeTableByDoctorId(d.Id);
                    if (crntListTimeTabelByDoctor.Count() != 0)
                    {
                        foreach (var timeTable in crntListTimeTabelByDoctor)
                        {
                            if (date.DayOfWeek == timeTable.DayOfWeek.Name.DayOfWeek)
                            {
                                TimeRecordingDto crntTimeRecording = new TimeRecordingDto()
                                {
                                    Date = date,
                                    TimeTableId = timeTable.Id,
                                    Occupied = false
                                };

                                TimeRecordingRepository.AddTimeRecording(crntTimeRecording);
                            }
                        }
                    }
                }
            }
        }
    }
}
