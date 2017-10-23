using System.Collections.Generic;

namespace WessleyMitchell.Extensions.IDictionaryExtensions
{
    public static class IDictionaryExtensions
    {
        public static TValue TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue value;
            dictionary.TryGetValue(key, out value);
            return value;
        }

        public static void AddRange<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, IEnumerable<KeyValuePair<TKey, TValue>> enumerable)
        {
            foreach (var kvp in dictionary)
            {
                dictionary.Add(kvp.Key, kvp.Value);
            }
        }
    }
}
