using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public static string GetSHA1String(this string text)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();
            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(text));
            //loop for each byte and add it to StringBuilder
            StringBuilder returnValue = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X2"));
            }
            return returnValue.ToString().ToLower();
        }

        public static string GetMD5String(this string text)
        {
            //create new instance of md5
            MD5 md5 = MD5.Create();
            //convert the input text to array of bytes
            byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(text));
            //loop for each byte and add it to StringBuilder
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString("X2"));
            }
            return returnValue.ToString().ToLower();
        }
    }
}
