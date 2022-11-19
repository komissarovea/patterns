using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy2
{
    internal class LogProcessor
    {

        ILogReader _logImporter;


        public void ProcessLogs()
        {
            foreach (LogEntry logEntry in _logImporter.Read())
            {
                Console.WriteLine(logEntry);
                //SaveLogEntry(logEntry);
            }
        }
    }
}
