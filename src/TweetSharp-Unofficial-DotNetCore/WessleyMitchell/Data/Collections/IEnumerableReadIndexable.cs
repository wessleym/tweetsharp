using System.Collections.Generic;

namespace WessleyMitchell.Data.Collections
{
    public interface IEnumerableReadIndexable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IReadIndexable<TKey, TValue>
    { }
}
