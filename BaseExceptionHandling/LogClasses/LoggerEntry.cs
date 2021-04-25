using System;
using BaseExceptionHandling.Interfaces;

namespace BaseExceptionHandling.LogClasses
{
    
    public class LoggerEntry
    {
        public int LineNumber { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public LogLevel LogLevel { get; set; }
    }
}
