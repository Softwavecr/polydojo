using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Findspace;
public class Program
{
    public class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
    }

    public static void Main(string[] args)
    {
        string heroesJson = @"[
            {""name"": ""Hulk"", ""strength"": 90000},
            {""name"": ""Spider-Man"", ""strength"": 25000},
            {""name"": ""Hawk Eye"", ""strength"": 136},
            {""name"": ""Thor"", ""strength"": 100000},
            {""name"": ""Black Widow"", ""strength"": 136},
            {""name"": ""Vision"", ""strength"": 5000},
            {""name"": ""Scarlet Witch"", ""strength"": 60},
            {""name"": ""Mystique"", ""strength"": 120},
            {""name"": ""Namora"", ""strength"": 75000},
            {""name"": ""Captain America"", ""strength"": 362},
            {""name"": ""Deadpool"", ""strength"": 1814},
            {""name"": ""Black Panther"", ""strength"": 1814}
        ]";

        List<Hero> heroes = JsonSerializer.Deserialize<List<Hero>>(heroesJson);

        Hero hulk = heroes.FirstOrDefault(hero => hero.Name == "Hulk");

        if (hulk != null)
        {
            Console.WriteLine(JsonSerializer.Serialize(hulk));
        }
        else
        {
            Console.WriteLine("Hulk not found.");
        }
    }
}
// execute in bash
//dotnet run find
//expected result
//