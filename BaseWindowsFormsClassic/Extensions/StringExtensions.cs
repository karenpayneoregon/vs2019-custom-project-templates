using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseWindowsFormsClassic.Extensions
{
    public static class StringExtensions
    {

        public static bool ContainsIgnoreCase(this string source, string substring) =>
            source?.IndexOf(substring ?? "", StringComparison.OrdinalIgnoreCase) >= 0;

    }
}
