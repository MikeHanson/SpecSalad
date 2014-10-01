using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecSalad.features
{
    public static class DictionaryExtensions
    {
        public static IDictionary<string, string> Subset(this IEnumerable<KeyValuePair<string, string>> source, params string[] keys)
        {
            return source.Where(item => keys.Contains(item.Key))
                         .ToDictionary(item => item.Key, item => item.Value);
        }

        public static string DefaultValue(this IEnumerable<KeyValuePair<string, string>> source)
        {
            var valuePairs = (from i in source select i).ToList();
            return !valuePairs.Any()
                       ? null
                       : valuePairs.First()
                                   .Value;
        }
    }
}