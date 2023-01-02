using Microsoft.Extensions.DependencyInjection;

using Template.Application.Interfaces;
using Template.Application.Services;
using Template.Data.Repositories;
using Template.Domain.Interfaces;

namespace Template.IoC
{
    public static class NativeInjector
    {

        public static void RegisterServicos(IServiceCollection services)
        {
            #region Servicer
            services.AddScoped<IUserService, UserService>();
            #endregion

            #region Repository
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion
        }
    }
}
