using System.Text.Json;
namespace polydojo;
class Program
{
    public static void DoHeroes(List<Hero> heroes)
    {
        List<Hero> hulk = Find.FindFunc(heroes,"Hulk");

        var names = Map.MapFunc<Hero, string>(heroes, x => x.Name+"!");

        //if (hulk != null) Prin.ter("2- Find Hulk: "+JsonSerializer.Serialize(hulk));
        //else Prin.ter("2- Find Hulk: Hulk not found.");


        Prin.ter("3- Map.");

        if (names != null) 
            foreach (var n in names)
                Prin.ter(n);

        //Prin.ter("\n3- Map complete.\n");

        Prin.ter("3- Map.");

        if (names != null) 
            foreach (var n in names)
                Prin.ter(n);

    }    
    public static void Main()
    {
        string filePath = "data.json";
        try
        {
            //Prin.ter("1- Print: Hello, J");
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