﻿using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace API.Configuration
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            NativeInjectorBootStrapper.RegisterServices(services);
        }


    }
}
