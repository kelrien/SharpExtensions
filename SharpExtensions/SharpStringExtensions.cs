using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExtensions
{
    public static class SharpStringExtensions
    {
        /// <summary>
        /// Replaces the first occurrence of a certain string in a source string
        /// </summary>
        /// <param name="text">The original string</param>
        /// <param name="target">target for replacement</param>
        /// <param name="replaceWith"></param>
        /// <returns></returns>
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
        /// <param name="text">The original string</param>
        /// <param name="target">target for replacement</param>
        /// <param name="replaceWith"></param>
        /// <returns></returns>
        public static string ReplaceLast(this string text, string target, string replaceWith)
        {
            throw new NotImplementedException();
        }
    }
}
