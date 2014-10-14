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
            int pos = text.LastIndexOf(target);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replaceWith + text.Substring(pos + target.Length);
        }

        //http://stackoverflow.com/questions/271398/what-are-your-favorite-extension-methods-for-c-codeplex-com-extensionoverflow
        //http://lukencode.com/2010/08/18/c-string-extension-methods/
        //http://blogs.msdn.com/b/bluecollar/archive/2010/10/25/c-extension-methods-syntactic-sugar-or-useful-tool.aspx
        //http://www.elijahtaylor.com/Tutorials/August-2009/My-Favorite-String-Extension-Methods-in-C-.aspx
        //http://www.dailycoding.com/posts/top_5_small_but_must_have_extension_methods.aspx
        //"ToMarkdown"?
    }
}
