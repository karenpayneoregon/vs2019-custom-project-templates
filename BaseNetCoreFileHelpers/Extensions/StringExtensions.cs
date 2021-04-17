using System.Linq;
using System.Text.RegularExpressions;

namespace BaseNetCoreFileHelpers.Extensions
{
	public static class StringExtensions
	{
		public static string StringBetweenQuotes(this string sender)
        {
            var match = Regex.Match(sender, "'([^']*)");

            return match.Success ? match.Groups[1].Value : sender;
        }

		public static bool ContainsAny(this string sender, params string[] values)
		{
			return values.Any(sender.Contains);
		}
	}

}