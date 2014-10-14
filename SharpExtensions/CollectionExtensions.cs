using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpExtensions
{
    public static class CollectionExtensions
    {

        /// <summary>
        /// Search for a value in a dictionary with a default value
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static V Get<K,V>(this Dictionary<K,V> dict, K key, V defaultValue)
        {
            if (dict.ContainsKey(key))
            {
                return dict[key];
            }
            else
            {
                return defaultValue;
            }
        }

    }
}
