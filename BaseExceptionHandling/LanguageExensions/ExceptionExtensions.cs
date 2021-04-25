using System;

// ReSharper disable once CheckNamespace
namespace ExceptionHandling
{
    /// <summary>
    /// Helper methods for logging exceptions
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Get InnerException if there is one as text.
        /// </summary>
        /// <param name="e"><see cref="Exception"/></param>
        /// <param name="result">Exception message</param>
        /// <returns></returns>
        public static string GetExceptionMessages(this Exception e, string result = "")
        {
            try
            {
                if (e == null) return string.Empty;

                if (string.IsNullOrWhiteSpace(result)) result = e.Message;

                if (e.InnerException != null)
                {
                    result += $": InnerException: {GetExceptionMessages(e.InnerException)}";
                }

                return result;
            }
            catch (Exception ex)
            {
                return $"Failure in ExceptionExtensions.{nameof(GetExceptionMessages)}: [{ex.Message}]";
            }
        }
    }
}