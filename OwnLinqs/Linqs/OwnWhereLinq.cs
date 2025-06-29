namespace OwnLinqs.Linqs;

public static class OwnWhereLinq
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(predicate);

        foreach (var eachSource in source)
        {
            if (predicate(eachSource))
                yield return eachSource;
        }

    }
}