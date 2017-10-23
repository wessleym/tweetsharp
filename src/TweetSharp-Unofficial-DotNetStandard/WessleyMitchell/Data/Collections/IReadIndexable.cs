namespace WessleyMitchell.Data.Collections
{
    public interface IReadIndexable<TKey, TValue>
    {
        TValue this[TKey key] { get; }
        bool TryGetValue(TKey key, out TValue value);
    }
}
