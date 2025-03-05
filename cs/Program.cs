using System.Text.Json;
namespace polydojo;
class Program
{    
    private static void DoHeroes(List<Hero> heroes)
    {
        Print.Do(" 1- Print: Hello, Heroes\n");

        List<Hero> hulk = Find.FindFunc(heroes,"Hulk");

        var names = Map.MapFunc(heroes, AppendSymbol);
        if (hulk != null) Print.Do("2- Find: "+JsonSerializer.Serialize(hulk)+'\n');

        Print.Do("3- Map:");
        foreach (var n in names)
            Print.Do(n);

        Print.Do("\n");

        Print.Do("4- Filter: ");
        var filteredHeroes = heroes.FilterFunc(Strong);
        
        foreach (var h in filteredHeroes)
            Print.Do(h.Name + " "+ h.Strength+ " ");
        
    }
    static readonly Func<Hero, string> AppendSymbol = hero => hero.Name + "!";
    static bool Strong(Hero hero) => hero.Strength >= 2000;
    public static void Main()
    {
        string filePath = "data.json";
        try
        {
            string jsonString = File.ReadAllText(filePath);
            var heroes = JsonSerializer.Deserialize<List<Hero>>(jsonString) ?? [];
            DoHeroes(heroes);
            Print.Do("\n");
        }
        catch (Exception ex)
        {
            throw new Exception("" + ex.Message);
        }
    }
}