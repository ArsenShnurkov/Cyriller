using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cyriller
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static string ReplaceRegex(this string value, string regexWhat, string replaceTo)
        {
            if (value.IsNullOrEmpty() || regexWhat.IsNullOrEmpty())
            {
                return value;
            }

            return Regex.Replace(value, regexWhat, replaceTo);
        }

        public static bool RegexHasMatches(this string value, string regexPattern, bool caseSensetive = false, bool multiLine = true)
        {
            value = value ?? string.Empty;
            RegexOptions options = !caseSensetive ? RegexOptions.IgnoreCase : RegexOptions.None;
            options |= multiLine ? RegexOptions.Multiline : options;
            return Regex.IsMatch(value, regexPattern, options);
        }

        public static string UppercaseFirst(this string value)
        {
            if (value.IsNullOrEmpty())
            {
                return string.Empty;
            }

            return char.ToUpper(value[0]) + value.Substring(1);
        }
    }
}
