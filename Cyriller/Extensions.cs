using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cyriller
{
    public static class Extensions
    {
        public static bool IsNullOrEmpty(this string Value)
        {
            return string.IsNullOrEmpty(Value);
        }

        public static bool IsNotNullOrEmpty(this string Value)
        {
            return !string.IsNullOrEmpty(Value);
        }

        public static string ReplaceRegex(this string Value, string RegexWhat, string ReplaceTo)
        {
            if (Value.IsNullOrEmpty() || RegexWhat.IsNullOrEmpty())
            {
                return Value;
            }

            return System.Text.RegularExpressions.Regex.Replace(Value, RegexWhat, ReplaceTo);
        }

        public static bool RegexHasMatches(this String Value, String RegexPattern, Boolean CaseSensetive = false, Boolean MultiLine = true)
        {
            Value = Value ?? string.Empty;
            RegexOptions options = !CaseSensetive ? RegexOptions.IgnoreCase : RegexOptions.None;
            options |= MultiLine ? RegexOptions.Multiline : options;
            return Regex.IsMatch(Value, RegexPattern, options);
        }

        public static string UppercaseFirst(this string Value)
        {
            if (Value.IsNullOrEmpty())
            {
                return string.Empty;
            }

            return char.ToUpper(Value[0]) + Value.Substring(1);
        }
    }
}
