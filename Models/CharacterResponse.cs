using System.Text.Json.Serialization;

namespace SearchDemonSlayerAPI.Models;

public class CharacterResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }

    [JsonPropertyName("content")]
    public List<Character> Content { get; set; } = new();
}

public class Pagination
{
    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }

    [JsonPropertyName("elementsOnPage")]
    public int ElementsOnPage { get; set; }

    [JsonPropertyName("currentPage")]
    public int CurrentPage { get; set; }

    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }
}
