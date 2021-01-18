﻿using Microsoft.Extensions.DependencyInjection;
using SoulWorkerPropertySimulator.Services;

namespace SoulWorkerPropertySimulator
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSoulWorkerPropertySimulator(this IServiceCollection self)
        {
            self.AddSingleton<IAccessoryComputeService, AccessoryComputeService>();
            self.AddSingleton<IAkashaComputeService, AkashaComputeService>();
            self.AddSingleton<IArmorComputeService, ArmorComputeService>();
            self.AddSingleton<IBroochesComputeService, BroochesComputeService>();
            self.AddSingleton<ICharacterComputeService, CharacterComputeService>();
            self.AddSingleton<ITitleComputeService, TitleComputeService>();
            self.AddSingleton<IAttackComputeService, AttackComputeService>();
            self.AddSingleton<IPanelComputeService, PanelComputeService>();

            return self;
        }
    }
}