using System.Collections.Generic;

namespace Strategy2
{
    internal interface ILogReader
    {
        LogEntry LogEntry { get; set; }

        List<LogEntry> Read();
    }
}