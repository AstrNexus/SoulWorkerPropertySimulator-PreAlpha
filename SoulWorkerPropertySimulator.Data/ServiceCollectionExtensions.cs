﻿using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Data.Services;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection InjectData(this IServiceCollection self)
        {
            self.AddSingleton<IDataProvideService, DataProvideService>();

            return self;
        }
    }
}