using System.Text.Json.Serialization;

namespace BlazorApplication.Data;
public class Coffee
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("ingredients")]
    public string[] Ingredients { get; set; } = new string[0];

    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public int Id { get; set; }
}