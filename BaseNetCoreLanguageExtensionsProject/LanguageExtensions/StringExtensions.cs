using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BaseNetCoreLanguageExtensionsProject.LanguageExtensions
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
        public static bool IsNullOrWhiteSpace(this string sender) => 
            string.IsNullOrWhiteSpace(sender);

        /// <summary>
        /// Join string array with " and " as the last delimiter.
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender) => 
            string.Join(", ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());

        /// <summary>
        /// Join string array with specified delimiter, " and " for the last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator(this string[] sender, string pDelimiter) => 
            string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : " and ")) + sender.LastOrDefault());

        /// <summary>
        /// Join string array with specified delimiter and last delimiter
        /// </summary>
        /// <param name="sender">String array to convert to delimited string</param>
        /// <param name="pDelimiter">Delimiter to separate array items</param>
        /// <param name="pLastDelimiter">Token used for final delimiter</param>
        /// <returns>Delimited string</returns>
        public static string JoinWithLastSeparator1(this string[] sender, string pDelimiter, string pLastDelimiter) => 
            string.Join(pDelimiter + " ", sender.Take(sender.Length - 1)) + ((((sender.Length <= 1) ? "" : pLastDelimiter)) + sender.LastOrDefault());

        /// <summary>
        /// Given a string with upper and lower cased letters separate them before each upper cased characters
        /// </summary>
        /// <param name="sender">String to work against</param>
        /// <returns>String with spaces between upper-case letters</returns>
        public static string SplitCamelCase(this string sender) => 
            Regex.Replace(Regex.Replace(sender, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2");
    }
}