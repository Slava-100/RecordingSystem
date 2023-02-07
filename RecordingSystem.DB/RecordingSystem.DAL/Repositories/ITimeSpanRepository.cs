using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Repositories
{
    public interface ITimeSpanRepository
    {
        public void AddTimeSpan(TimeSpan start, TimeSpan end);
    }
}
