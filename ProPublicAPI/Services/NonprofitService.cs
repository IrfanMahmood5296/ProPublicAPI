using Newtonsoft.Json;
using ProPublicAPI.Interfaces;
using ProPublicAPI.Models;

namespace ProPublicAPI.Services
{
    public class NonprofitService: INonprofitService
    {
        private readonly HttpClient _httpClient;
        private const string ProPublicaApiBaseUrl = "https://projects.propublica.org/nonprofits/api/v2/";

        public NonprofitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(ProPublicaApiBaseUrl); 
        }

        public async Task<NonProfitOrganizations?> SearchNonProfitsAsync(string query, int page = 0, int perPage = 10)
        {
            var url = $"search.json?q={query}&page={page}&per_page={perPage}";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<NonProfitOrganizations>(json);
            return result;
        }

        public async Task<NonProfitOrganizationDetail?> GetOrganizationDetailAsync(string ein)
        {
            if (string.IsNullOrWhiteSpace(ein))
                return null;

            var url = $"organizations/{ein}.json";

            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<NonProfitOrganizationDetail>(json);
        }
    }
}
