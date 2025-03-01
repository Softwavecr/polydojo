using System.Text.Json;
namespace polydojo;
class Program
{
    public static void DoHeroes(List<Hero> heroes)
    {
        //printall
        //if (heroes != null) foreach (Hero h in heroes) Pr($"Name:{h.Name},Strength:{h.Strength}"); else Pr("Deserialization failed.");
        List<Hero> hulk = Find.FindFunc(heroes,"Hulk");

        if (hulk != null) Prin.ter(JsonSerializer.Serialize(hulk));
        else Prin.ter("Hulk not found.");            
    }    
    public static void Main()
    {
        string filePath = "data.json";
        try
        {
            Prin.ter("Hello, J");
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