
using Microsoft.Extensions.Options;
using System.Text.Json;
using TropicosSyncLib.Configuration;
using TropicosSyncLib.Models;

namespace TropicosSyncLib.Services
{
    public class TropicosApiClient : ITropicosApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly TropicosOptions _options;

        public TropicosApiClient(HttpClient httpClient, IOptions<TropicosOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<List<TropicosSpeciesDto>> GetSpeciesAsync(string name)
        {
            var url = $"{_options.BaseUrl}/species?name={name}&apikey={_options.ApiKey}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<TropicosSpeciesDto>>(responseContent);
        }
    }
}
