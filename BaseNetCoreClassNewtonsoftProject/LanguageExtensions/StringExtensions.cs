using System.Diagnostics;
using System.Globalization;

namespace BaseNetCoreClassNewtonsoftProject.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if empty or false if not empty</returns>
        [DebuggerStepThrough]
        public static bool IsNullOrWhiteSpace(this string sender) => string.IsNullOrWhiteSpace(sender);

        /// <summary>
        /// Determine if string is empty
        /// </summary>
        /// <param name="sender">String to test if null or whitespace</param>
        /// <returns>true if not or false if empty</returns>
        [DebuggerStepThrough]
        public static bool IsNotNullOrWhiteSpace(this string sender) => !string.IsNullOrWhiteSpace(sender);

        /// <summary>
        /// Determine if a string can be represented as a numeric.
        /// </summary>
        /// <param name="text">value to determine if can be converted to a string</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        public static bool IsNumeric(this string text) => double.TryParse(text, out _);
        [DebuggerStepThrough]
        public static string ToTitleCase(this string sender) => sender.IsNullOrWhiteSpace() ? sender : CultureInfo.InvariantCulture.TextInfo.ToTitleCase(sender.ToLower());

    }
}
