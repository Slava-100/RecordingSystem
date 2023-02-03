using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordingSystem.DAL
{
    public class Options
    {
        public static string sqlConnection = Environment.GetEnvironmentVariable("RecordingSystem");
    }
}
