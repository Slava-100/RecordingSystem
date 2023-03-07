using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Models;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
	public class TimeSpanManager
	{
		private Mapperrr _mapperrr = new Mapperrr();
		public ITimeSpanRepository TimeSpanRepository { get; set; }

		public TimeSpanManager()
		{
			TimeSpanRepository = new TimeSpanRepository();
		}

		public void UpdateTimeSpanById(UpdateTimeSpanInputModel updateTimeSpanInputModel)
		{
			var timeSpanDto = _mapperrr.MapUpdateTimeSpanInputModelToTimeSpanDto(updateTimeSpanInputModel);
			TimeSpanRepository.UpdateTimeSpanById(timeSpanDto);
		}

		public List<TimeSpanOutputModel> GetAllTimeSpan()
		{
			var timeSpans = TimeSpanRepository.GetAllTimeSpan();
			var result = _mapperrr.MapListTimeSpanDtoToListTimeSpanOutputModel(timeSpans);

			return result;
		}

		public void AddTimeSpan(TimeSpanInputModel timeSpan)
		{
			var timeSpanDto = _mapperrr.MapTimeSpanInputModelToTimeSpanDto(timeSpan);
			TimeSpanRepository.AddTimeSpan(timeSpanDto);
		}
	}
}
