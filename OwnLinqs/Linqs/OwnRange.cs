namespace OwnLinqs.Linqs;

public class OwnRange
{
    public static IEnumerable<int> Range(int start, int count)
    {
        if ((long)start + (long)count - 1L > int.MaxValue) throw new ArgumentOutOfRangeException();
        while (start < count)
        {
            yield return start++;
        }
    }
}