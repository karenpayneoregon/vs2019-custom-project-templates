using System;
using System.Threading;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BaseNetCoreOracleProviderClassProject.Classes
{
    public class DataOperations : BaseExceptionProperties
    {
        /// <summary>
        /// Connection string to database
        /// </summary>
        private static readonly string ConnectionString = "TODO";

        /// <summary>
        /// Partly completed template for reading data.
        /// * Replace Task&lt;bool&gt; with the proper return type
        /// 
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public static async Task<bool> Read(CancellationToken ct)
        {
            mHasException = false;

            const string SelectStatement = "TODO";

            // ReSharper disable once MethodSupportsCancellation
            return await Task.Run(async () =>
            {
                await using var cn = new OracleConnection(ConnectionString);
                await using var cmd = new OracleCommand { Connection = cn, CommandText = SelectStatement };

                try
                {
                    await cn.OpenAsync(ct);

                    // ReSharper disable once MethodSupportsCancellation
                    var reader = await cmd.ExecuteReaderAsync();

                    return true;
                }
                catch (Exception exception)
                {
                    mHasException = true;
                    mLastException = exception;
                    
                    return false;
                }

            });
        }


    }
}
