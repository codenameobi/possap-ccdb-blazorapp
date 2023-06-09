﻿using POSSAP_CCDB.Data.Response;
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

        public async Task<GetTenRecentConvictsResponse> GetTestAsync()
        {
            var fileContent = await File.ReadAllTextAsync("Data/recentconvicts.json");
            var data = JsonSerializer.Deserialize<GetTenRecentConvictsResponse>(fileContent);
            return data;
        }

        public async Task<GetTenRecentConvictsResponse> GetTenRecentConvictsAsync()
        {
            var token = await _localStorageService.GetItemAsync<string>("access_token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());

            var response = await _httpClient.GetAsync("https://possap-ccdb.ogtlprojects.com/api/Dashboard/recent-added-convicts");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                
                try {
                    var data = JsonSerializer.Deserialize<GetTenRecentConvictsResponse>(responseContent);
                    return data;
                }
                catch
                {
                    throw;
                }
    
            }
            else
            {
                throw new HttpRequestException($"Error calling API: {response.StatusCode}");
            }
        }

        public async Task<DEConvictReportCountsResponse> GetDataEntryConvictReportCounts()
        {
            var token = await _localStorageService.GetItemAsync<string>("access_token");
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.ToString());

            var response = await _httpClient.GetAsync("https://possap-ccdb.ogtlprojects.com/api/Dashboard/data-entry-reports-counts");
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();

                try
                {
                    var data = JsonSerializer.Deserialize<DEConvictReportCountsResponse>(responseContent);
                    return data;
                }
                catch
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
