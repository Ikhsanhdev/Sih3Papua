using Sih3Papua.Interfaces;
using Sih3Papua.Repositories;
using Sih3Papua.Services;

namespace Sih3Papua
{
  public static class ServiceCollectionteExtension
  {
    public static void RegisterServices(this IServiceCollection services)
    {
      #region ========== [ Register Unit Of Works ] ==========
      services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
      services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();
      #endregion

      #region ========== [ Register Services ] ==========
      services.AddScoped<IAuthService, AuthService>();
      #endregion

      #region ========== [ Register Repositories ] ==========
      services.AddScoped<IUserRepository, UserRepository>();
      #endregion
    }
  }
}