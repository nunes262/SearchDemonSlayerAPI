using System.Net.Http.Json;
using SearchDemonSlayerAPI.Models;

namespace SearchDemonSlayerAPI.Services;

public class DemonSlayerService
{
    private readonly HttpClient _http;

    public DemonSlayerService(HttpClient http)
    {
        _http = http;
    }

    // Lista os personagens de forma paginada
    public async Task<CharacterResponse> GetCharactersAsync(int page = 1)
    {
        var response = await _http.GetFromJsonAsync<CharacterResponse>($"characters?page={page}");
        return response ?? new CharacterResponse();
    }

    // Busca personagens pelo nome
    public async Task<CharacterResponse> SearchByNameAsync(string name)
    {
        var url = $"characters?name={Uri.EscapeDataString(name)}";
        var httpResponse = await _http.GetAsync(url);

        // A API retorna 404 quando nenhum personagem é encontrado
        if (httpResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return new CharacterResponse();
        }

        httpResponse.EnsureSuccessStatusCode();
        var response = await httpResponse.Content.ReadFromJsonAsync<CharacterResponse>();
        return response ?? new CharacterResponse();
    }
}
