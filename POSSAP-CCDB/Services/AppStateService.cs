using Fluxor;
using POSSAP_CCDB.Data;
using POSSAP_CCDB.Data.State;

namespace POSSAP_CCDB.Services
{
    public class UpdateUserAction
    {
        public AppUser User { get; set; }
        public UpdateUserAction(AppUser user)
        {
            User = user;
        }
    }

    public class UserReducer
    {
        [ReducerMethod]
        public static UserState ReduceUpdateUserAction(UserState state, UpdateUserAction action) 
        { 
            return new UserState { CurrentUser = action.User };
        }
    }

    
}
