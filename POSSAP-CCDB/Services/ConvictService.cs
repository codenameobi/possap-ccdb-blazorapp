using Blazored.LocalStorage;
using POSSAP_CCDB.Data.Request;
using System.Net.Http.Json;

namespace POSSAP_CCDB.Services
{
    

    public class ConvictService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly ILocalStorageService _localStorageService;

        public ConvictService(HttpClient httpClient, ILogger logger, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
            _logger = logger;
        }

        public async Task<bool> AddConvict(CreateConvictRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<CreateConvictRequest>("https://possap-ccdb.ogtlprojects.com/api/Convict/add-convict", request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    throw new ApplicationException($"Error posting data: {response.StatusCode} - {errorResponse}");
                }
            }catch (Exception ex)
            {
                throw new ApplicationException("Error posting data", ex);
            }
        }

        public async Task<bool> UploadPassports(UploadPassportRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<UploadPassportRequest>("https://possap-ccdb.ogtlprojects.com/api/Convict/add-convict", request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    throw new ApplicationException($"Error posting data: {response.StatusCode} - {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error posting data", ex);
            }
        }
    }


}
