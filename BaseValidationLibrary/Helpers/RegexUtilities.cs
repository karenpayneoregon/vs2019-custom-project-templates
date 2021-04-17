using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BaseValidationLibrary.Helpers
{
    /// <summary>
    /// Taken from Microsoft, added a check for a single apostrophe check at end of address
    /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
    /// </summary>
    public class RegexUtilities
    {

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", 
                    DomainMapper, 
                    RegexOptions.None, 
                    TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(RemoveSingleQuotes(email), @"^[^@\s]+@[^@\s]+\.[^@\s]+$", 
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)) ;
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Removes trailing en ending single quotes from an E-mail address when they exist
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string RemoveSingleQuotes(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return string.Empty;
            }

            if (email.StartsWith("'"))
            {
                email = email.Substring(1, email.Length - 1);
            }

            if (email.EndsWith("'"))
            {
                email = email.Substring(0, email.Length - 1);
            }

            return email;
        }
    }
}
