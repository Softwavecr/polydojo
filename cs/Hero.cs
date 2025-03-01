using System.Text.Json.Serialization;
public struct Hero
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
}