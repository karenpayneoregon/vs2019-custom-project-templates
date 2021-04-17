﻿using System.Text.RegularExpressions;

namespace BaseValidationLibrary.Helpers
{
    public static class Extensions
    {
        public static bool IsValidEmail(this string email)
        {
            var pattern = 
                @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + 
                @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
    }
}
