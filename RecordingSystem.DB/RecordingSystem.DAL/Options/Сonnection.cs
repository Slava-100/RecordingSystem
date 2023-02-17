using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL.Options
{
    public class Сonnection
    {
        public static string sqlConnection = Environment.GetEnvironmentVariable("RecordingSystem");
    }
}
