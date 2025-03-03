using System.Text.Json;
namespace polydojo;
class Program
{
    public static void DoHeroes(List<Hero> heroes)
    {
        List<Hero> hulk = Find.FindFunc(heroes,"Hulk");

        if (hulk != null) Prin.ter("2- "+JsonSerializer.Serialize(hulk));
        else Prin.ter("2- Hulk not found.");            
    }    
    public static void Main()
    {
        string filePath = "data.json";
        try
        {
            Prin.ter("1- Print: Hello, J");
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