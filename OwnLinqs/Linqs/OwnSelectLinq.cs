namespace OwnLinqs.Linqs;

public static class OwnSelectLinq
{
    public static IEnumerable<T> OwnSelect<T>(this IEnumerable<T> source, Func<T, T> selector)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(selector);

        foreach (var eachSource in source)
        {
            yield return selector(eachSource);
        }
    }
}