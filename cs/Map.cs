public static class Map
{
    public static List<TResult> MapFunc<T, TResult>(
        this List<T> list, Func<T, TResult> func)
    {
        var result = new List<TResult>();
        foreach (var item in list)
        {
            result.Add(func(item));
        }
        return result;
    }
}