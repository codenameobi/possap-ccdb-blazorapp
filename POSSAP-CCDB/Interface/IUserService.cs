using POSSAP_CCDB.Data;

namespace POSSAP_CCDB.Interface
{
    public interface IUserService
    {
        Task<AppUser> GetUserAsync();
        Task SetUserAsync(AppUser user);
    }
}
