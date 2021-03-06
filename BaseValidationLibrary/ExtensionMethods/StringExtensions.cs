using System.Text.RegularExpressions;

namespace BaseValidationLibrary.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string SplitCamelCase(this string sender)
        {
            return Regex.Replace(Regex.Replace(sender, "(\\P{Ll})(\\P{Ll}\\p{Ll})", "$1 $2"), "(\\p{Ll})(\\P{Ll})", "$1 $2");
        }
    }
}
