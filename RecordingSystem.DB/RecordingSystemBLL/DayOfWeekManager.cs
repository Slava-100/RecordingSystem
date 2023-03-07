using RecordingSystem.BLL.Models;
using RecordingSystem.DAL.Interfaces;
using RecordingSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL
{
	public class DayOfWeekManager
	{
		private Mapperrr _mapperrr = new Mapperrr();
		public IDayOfWeekRepository DayOfWeekRepository { get; set; }

		public DayOfWeekManager()
		{
			DayOfWeekRepository = new DayOfWeekRepository();
		}

		public List<DayOfWeekOutputModel> GetAllDayOfWeek()
		{
			var dayOfWeeks = DayOfWeekRepository.GetAllDayOfWeek();
			var result = _mapperrr.MapListDayOfWeeksDtoToListDayOfWeeksOutputModel(dayOfWeeks);

			return result;
		}
	}
}
