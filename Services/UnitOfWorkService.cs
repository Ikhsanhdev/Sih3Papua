using Sih3Papua.Interfaces;

namespace Sih3Papua.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        public UnitOfWorkService(
            IAuthService authService
        )
        {
            Auths = authService;
        }

        public IAuthService Auths { get; }
    }
}