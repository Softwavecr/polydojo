using System.Text.Json.Serialization;
public record Hero
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    [JsonPropertyName("strength")]
    public int Strength { get; set; }
}