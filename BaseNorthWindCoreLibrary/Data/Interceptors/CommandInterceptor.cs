using System.Data.Common;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BaseNorthWindCoreLibrary.Data.Interceptors
{
    public class CommandInterceptor : DbCommandInterceptor
    {
        public override DbDataReader ReaderExecuted(DbCommand command, 
            CommandExecutedEventData eventData, DbDataReader result)
        {
            Debug.WriteLine($"KAREN ReaderExecuted: {command.CommandText}");
            return base.ReaderExecuted(command, eventData, result);
        }
    }
}
