public class Find
{
    public static List<Hero> FindFunc(List<Hero> heroes, string target) => 
        heroes.FindAll(hero => hero.Name == target);    
}
//{"name":"Hulk","strength":90000}
