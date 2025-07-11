using Sih3Papua.Services;

namespace Sih3Papua.Interfaces
{
    public interface IUnitOfWorkService
    {
        IAuthService Auths { get; }
    }
}
