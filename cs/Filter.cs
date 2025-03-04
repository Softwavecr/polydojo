public static class Filter
{
    public static List<T> FilterFunc<T>(
        this List<T> list,
        Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach (var item in list)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}