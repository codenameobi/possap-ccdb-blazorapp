using POSSAP_CCDB.Data.Response;

namespace POSSAP_CCDB.Interface
{
    public interface IDashboardService
    {
        Task<List<GetTenRecentConvictsResponse>> GetTenRecentConvictsAsync();
    }
}
