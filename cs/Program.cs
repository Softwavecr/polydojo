using System.Text.Json;
namespace polydojo;
class Program
{    
    public static void DoHeroes(List<Hero> heroes)
    {
         List<Hero> hulk = Find.FindFunc(heroes,"Hulk");

         var names = Map.MapFunc(heroes, AppendSymbol);

         if (hulk != null) Prin.ter("2- Find Hulk: "+JsonSerializer.Serialize(hulk)+'\n');
         else Prin.ter("2- Find Hulk: Hulk not found.\n");

        Prin.ter("3- Map. ");
        if (names != null) 
            foreach (var n in names)
                Prin.ter(n);

        Prin.ter("\n");

        Prin.ter("4- Filter. ");

        var filteredHeroes = 
            heroes.FilterFunc(Strong);

        if (filteredHeroes != null) 
            foreach (var h in filteredHeroes)
                Prin.ter(h.Name + " "+ h.Strength+ " ");

        Prin.ter("\n");

    }
    static readonly Func<Hero, string> AppendSymbol = hero => hero.Name + "!";
    static bool Strong(Hero hero) => hero.Strength >= 2000;
    public static void Main()
    {
        string filePath = "data.json";
        try
        {
            Prin.ter("1- Print: Hello, J\n");
            string jsonString = File.ReadAllText(filePath);
            List<Hero> heroes = JsonSerializer.Deserialize<List<Hero>>(jsonString);
            DoHeroes(heroes);
        }
        catch (Exception ex)
        {
            throw new Exception("" + ex.Message);
        }
    }
}