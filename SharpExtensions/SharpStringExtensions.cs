using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SharpExtensions
{
    public static class SharpStringExtensions
    {
        /// <summary>
        /// Replaces the first occurrence of a certain string in a source string
        /// </summary>
        public static string ReplaceFirst(this string text, string target, string replaceWith)
        {
            int pos = text.IndexOf(target);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replaceWith + text.Substring(pos + target.Length);
        }

        /// <summary>
        /// Replaces the last occurrence of a certain string in a source string
        /// </summary>
        public static string ReplaceLast(this string text, string target, string replaceWith)
        {
            int pos = text.LastIndexOf(target);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replaceWith + text.Substring(pos + target.Length);
        }

        /// <summary>
        /// Checks if a given string is a valid email address
        /// </summary>
        public static bool IsValidEmailAddress(this string text)
        {
            Regex rx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return rx.IsMatch(text);
        }

        /// <summary>
        /// Checks if the given string is a valid url
        /// </summary>
        public static bool IsValidUrl(this string text)
        {
            Regex rx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
            return rx.IsMatch(text);
        }

        /// <summary>
        /// Reverses a string
        /// </summary>
        public static string Reverse(this string text)
        {
            return new string(text.ToCharArray().Reverse().ToArray<char>());
        }

        /// <summary>
        /// "Nicer" version to format strings
        /// </summary>
        public static string Format(this string text, params object[] args)
        {
            return string.Format(text, args);
        }
    }
}
