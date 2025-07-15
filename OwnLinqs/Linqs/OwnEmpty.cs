namespace OwnLinqs.Linqs;

public class OwnEmpty
{
    public static IEnumerable<T> Empty<T>()
    {
        yield break;
    }
}