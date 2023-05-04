using Microsoft.JSInterop;
using System.Threading.Tasks;


namespace POSSAP_CCDB.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            return await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "access_token");
        }

        public async Task SetAccessTokenAsync(string accessToken)
        {
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "access_token", accessToken);
        }
    }
}
