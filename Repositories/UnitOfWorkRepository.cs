using Sih3Papua.Interfaces;

namespace Sih3Papua.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public UnitOfWorkRepository(
            IUserRepository userRepository
        )
        {
            User = userRepository;
        }

        public IUserRepository User { get; }
    }
}
