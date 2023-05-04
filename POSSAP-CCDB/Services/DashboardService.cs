using POSSAP_CCDB.Data.Response;
using POSSAP_CCDB.Interface;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text.Json;
using Blazored.LocalStorage;
using POSSAP_CCDB.Data.State;

namespace POSSAP_CCDB.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly ILocalStorageService _localStorageService;

        public DashboardService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public async Task<List<GetTenRecentConvictsResponse>> GetTenRecentConvictsAsync()
        {
            var token = await _localStorageService.GetItemAsync<string>("access_token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());

            var response = await _httpClient.GetAsync("https://possap-ccdb.ogtlprojects.com/api/Dashboard/recent-added-convicts");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                
                try {
                    //var data = JsonConvert.DeserializeObject<List<GetTenRecentConvictsResponse>>(responseContent);
                    var data = JsonSerializer.Deserialize<List<GetTenRecentConvictsResponse>>(responseContent);
                    return data;
                }
                catch(Exception ex)
                {
                    throw;
                }
                
            }
            else
            {
                throw new HttpRequestException($"Error calling API: {response.StatusCode}");
            }
        }
    }
}
