using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace BaseNetCoreSqlClientClassProject.Classes
{
    /// <summary>
    /// Base code to get started
    /// * BaseExceptionProperties is optional, alternate would be a named value tuple
    /// </summary>
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
            
            var SelectStatement = "TODO";
            
            // ReSharper disable once MethodSupportsCancellation
            return await Task.Run(async () =>
            {
                await using var cn = new SqlConnection(ConnectionString);
                await using var cmd = new SqlCommand { Connection = cn, CommandText = SelectStatement };

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
