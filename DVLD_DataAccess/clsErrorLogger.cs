using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsErrorLogger
    {
        private static string EventLoggerSource = "DVLD";

        public static void LogEvent(string EventMessage)
        {
            if (!EventLog.SourceExists(EventLoggerSource))
            {
                EventLog.CreateEventSource(EventLoggerSource, "Application");
            }

            EventLog.WriteEntry(EventLoggerSource, EventMessage, EventLogEntryType.Error);
        }


    }
}
