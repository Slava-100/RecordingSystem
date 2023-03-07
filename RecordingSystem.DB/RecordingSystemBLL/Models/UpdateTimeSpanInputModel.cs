using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.BLL.Models
{
	public class UpdateTimeSpanInputModel
	{
		public int Id { get; set; }
		public TimeSpan? Start { get; set; }
		public TimeSpan? End { get; set; }
	}
}
