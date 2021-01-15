﻿using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data
{
    internal static class ArmorData
    {
        private static IReadOnlyCollection<ArmorBlueprint>? _armorBlueprintResult;

        internal static IReadOnlyCollection<ArmorBlueprint> Get()
        {
            if (_armorBlueprintResult != null) { return _armorBlueprintResult; }

            var result = new List<ArmorBlueprint>();
            var weapon68 = new ArmorBlueprint("進階幕光的流浪者",
                ArmorField.Weapon,
                68,
                ArmorRare.Legendary,
                4,
                new List<EffectRandomContext>
                {
                    new(new EffectContext(Property.AttackSpeedRate), .01m, .06m),
                    new(new EffectContext(Property.Accuracy), 16, 65),
                    new(new EffectContext(Property.ExtraDamageRateBasic), .02m, .09m),
                    new(new EffectContext(Property.ExtraDamageRateBoss), .02m, .09m),
                    new(new EffectContext(Property.CriticalRate), .02m, .07m),
                    new(new EffectContext(Property.CriticalDamage), 1885, 1743),
                    new(new EffectContext(Property.SuperArmorBreakPowerRate), .02m, .11m),
                    new(new EffectContext(Property.DefenseBreakRate), .01m, .06m),
                    new(new EffectContext(Property.SoulNovaVolumeRate), .01m, .07m),
                    new(new EffectContext(Property.KillHPRecovery), 28, 217)
                },
                3,
                Property.Attack,
                2175,
                3234,
                fixedEffects: new List<Effect>
                {
                    new(new EffectContext(Property.Attack), 3_726),
                    new(new EffectContext(Property.AttackSpeedRate), .07m),
                    new(new EffectContext(Property.ExtraDamageRateBoss), .3m),
                    new(new EffectContext(Property.CriticalDamage), 2_000),
                    new(new EffectContext(Property.Accuracy), -50)
                });
            result.Add(weapon68);
            result.Add(weapon68 with {Name = "進階幕光的平流"});
            result.Add(weapon68 with {Name = "進階幕光的榮耀"});
            result.Add(weapon68 with {Name = "進階幕光憐憫頌"});
            result.Add(weapon68 with {Name = "進階幕光的細緻"});
            result.Add(weapon68 with {Name = "進階幕光的廢墟"});
            result.Add(weapon68 with {Name = "進階幕光的追跡"});
            result.Add(weapon68 with {Name = "進階幕光的畸變"});

            var gear68 = new ArmorBlueprint("進階幕光鳶尾戰盔",
                ArmorField.Head,
                68,
                ArmorRare.Legendary,
                4,
                new List<EffectRandomContext>
                {
                    new(new EffectContext(Property.Attack), 36, 198),
                    new(new EffectContext(Property.Accuracy), 7, 37),
                    new(new EffectContext(Property.CriticalDamage), 140, 659),
                    new(new EffectContext(Property.HP), 2_365, 11_100),
                    new(new EffectContext(Property.CriticalRate), .01m, .07m),
                    new(new EffectContext(Property.CooldownShorterRate), .01m, .05m),
                    new(new EffectContext(Property.Defense), 66, 250),
                    new(new EffectContext(Property.Evade), 14, 69),
                    new(new EffectContext(Property.ExpVolumeRateEnemy), .02m, .12m),
                    new(new EffectContext(Property.PartialDamageRate), .01m, .09m)
                },
                3,
                Property.Defense,
                2175,
                3234,
                new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitCommon, .1m, 2), .07m)}},
                    {6, new Effect[] {new(new(Property.DefenseRate), .36m)}},
                    {9, new Effect[] {new(new(Property.ExtraDamageRateBoss), .03m)}}
                },
                "進階幕光套裝",
                new List<Effect>
                {
                    new(new EffectContext(Property.SoulNovaVolumeRate), .3m),
                    new(new EffectContext(Property.DamageReductionRateBoss), .08m),
                    new(new EffectContext(Property.Evade), -100)
                });
            result.Add(gear68);
            result.Add(gear68 with
            {
                Name = "進階幕光光輪護肩",
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {3, new Effect[] {new(new(Property.AttackRate, Opportunity.HitBoss, .1m, 2), .06m)}},
                    {6, new Effect[] {new(new(Property.Evade), 120)}},
                    {9, new Effect[] {new(new(Property.Accuracy), 390)}}
                },
                FixedEffects = new List<Effect>
                {
                    new(new EffectContext(Property.DamageReductionRateCritical), .18m),
                    new(new EffectContext(Property.Accuracy), 59),
                    new(new EffectContext(Property.Stamina), -20)
                }
            });
            result.Add(gear68 with
            {
                Name = "進階幕光忠心護甲",
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3, new Effect[] {new(new(Property.SoulGateRecoveryRate, Opportunity.UseAvoid, .05m), .12m)}
                    },
                    {6, new Effect[] {new(new(Property.HP), 2_500)}},
                    {9, new Effect[] {new(new(Property.CriticalRate), .06m)}}
                },
                FixedEffects = new List<Effect>
                {
                    new(new EffectContext(Property.HP), 5_994),
                    new(new EffectContext(Property.KillHPRecovery), 80),
                    new(new EffectContext(Property.Defense), -10000)
                }
            });
            result.Add(gear68 with
            {
                Name = "進階幕光代償護腿",
                StepEffects = new Dictionary<int, IReadOnlyCollection<Effect>>
                {
                    {
                        3,
                        new Effect[] {new(new(Property.CriticalDamage, Opportunity.SuperArmorBreak, .1m, 3), .65m)}
                    },
                    {6, new Effect[] {new(new(Property.DamageReductionRate), .06m)}},
                    {9, new Effect[] {new(new(Property.DefenseBreakRate), .06m)}}
                },
                FixedEffects = new List<Effect>
                {
                    new(new EffectContext(Property.Evade), 89),
                    new(new EffectContext(Property.MoveSpaceRate), .1m),
                    new(new EffectContext(Property.DamageReductionRate), -.05m)
                }
            });

            return _armorBlueprintResult = result;
        }
    }
}