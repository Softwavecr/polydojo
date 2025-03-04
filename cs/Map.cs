/*public class Map
{
    public static List<Hero> MapFunc(List<Hero> heroes, ) => 
        heroes.FindAll(hero => hero.Name == target);    
}
*/

public static class Map
{
    public static List<TResult> MapFunc<T, TResult>(this List<T> list, Func<T, TResult> func)
    {
        var result = new List<TResult>();
        foreach (var item in list)
        {
            result.Add(func(item));
        }
        return result;
    }
}
/*
class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var squares = numbers.Map(x => x * x);
        
        Console.WriteLine(string.Join(", ", squares)); // Output: 1, 4, 9, 16, 25
    }
}*/