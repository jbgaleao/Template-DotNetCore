﻿using Microsoft.Extensions.DependencyInjection;

using Template.Application.Interfaces;
using Template.Application.Services;

namespace Template.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServicos(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}
