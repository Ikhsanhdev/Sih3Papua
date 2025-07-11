using Sih3Papua.Repositories;

namespace Sih3Papua.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IUserRepository User { get; }
    }
}
