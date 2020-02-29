using Invoice.Core.Entity;
using Invoice.Core.ViewModel;

namespace Invoice.Core.Interfaces.Base
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        bool ValidateUser(LoginViewModel user);
    }
}
