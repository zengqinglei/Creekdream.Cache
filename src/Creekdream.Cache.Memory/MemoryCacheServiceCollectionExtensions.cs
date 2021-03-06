﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace Creekdream.Cache.Memory
{
    /// <summary>
    /// Cache service extension
    /// </summary>
    public static class MemoryCacheServiceCollectionExtensions
    {
        /// <summary>
        /// Add Memory Cache Service
        /// </summary>
        public static void AddCreekdreamMemoryCache(this IServiceCollection services, Action<MemoryCacheOptions> configOptions)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (configOptions == null)
            {
                throw new ArgumentNullException(nameof(configOptions));
            }
            services.AddOptions();
            services.Configure(configOptions);
            services.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
