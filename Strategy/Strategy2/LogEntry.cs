using System;
using System.Xml.Schema;

namespace Strategy2
{
    public class LogEntry
    {
        public DateTime DateTime { get; set; }

        public XmlSeverityType Severity { get; set; }

        public string Message { get; set; }
    }
}