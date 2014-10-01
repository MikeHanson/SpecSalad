using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecSalad
{
    public static class DictionaryExtensions
    {
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