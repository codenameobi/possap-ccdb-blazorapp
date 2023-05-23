using POSSAP_CCDB.Data;
using POSSAP_CCDB.Interface;

namespace POSSAP_CCDB.Services
{
    public class UserService : IUserService
    {
        private AppUser _currentUser;
        public async Task<AppUser> GetUserAsync()
        {
            return _currentUser;
        }

        public async Task SetUserAsync(AppUser user)
        {
            _currentUser = user;
        }
    }
}
