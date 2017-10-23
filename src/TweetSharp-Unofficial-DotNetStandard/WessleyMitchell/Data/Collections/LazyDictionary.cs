using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace WessleyMitchell.Data.Collections
{
    public class LazyDictionary<TKey, TValue> : IEnumerableReadIndexable<TKey, TValue>
    {
        private ConcurrentDictionary<TKey, TValue> dictionary;
        private Func<TKey, TValue> valueFactory;
        public LazyDictionary(Func<TKey, TValue> valueFactory)
        {
            dictionary = new ConcurrentDictionary<TKey, TValue>();
            this.valueFactory = valueFactory;
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public TValue this[TKey key]
        {
            get
            {
                return dictionary.GetOrAdd(key, valueFactory);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return dictionary.TryGetValue(key, out value);
        }
    }
}
