using System.Collections.Generic;
using System.Globalization;

namespace BaseExceptionHandling.LogClasses
{
    /// <summary>
    /// 
    /// </summary>
    public class LogContainer
    {
        /// <summary>
        /// 
        /// </summary>
        public LoggerEntry LoggerEntry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Lines { get; set; }

        /// <summary>
        /// Instantiate <see cref="Lines"/> as a new list
        /// </summary>
        public LogContainer()
        {
            Lines = new List<string>();
        }
        /// <summary>
        /// 
        /// </summary>
        public string[] ItemArray => new[]
        {
            LoggerEntry.LogLevel.ToString(), 
            LoggerEntry.DateTimeStamp.ToString(CultureInfo.InvariantCulture)
        };
    }
}