﻿using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

// ReSharper disable once CheckNamespace
namespace SoulWorkerPropertySimulator.Data.Storage
{
    internal static partial class BroochesData
    {
        private static Brooches _sinA1;
        private static Brooches _sinA2;
        private static Brooches _sinA3;
        private static Brooches _sinA4;
        private static Brooches _sinA5;
        private static Brooches _sinA6;
        private static Brooches _sinA7;
        private static Brooches _sinA8;
        private static Brooches _sinA9;
        private static Brooches _sinA10;

        private static Brooches _sinD1;
        private static Brooches _sinD2;
        private static Brooches _sinD3;
        private static Brooches _sinD4;
        private static Brooches _sinD5;
        private static Brooches _sinD6;
        private static Brooches _sinD7;
        private static Brooches _sinD8;
        private static Brooches _sinD9;
        private static Brooches _sinD10;

        private static Brooches _sinE1;
        private static Brooches _sinE2;
        private static Brooches _sinE3;
        private static Brooches _sinE4;
        private static Brooches _sinE5;
        private static Brooches _sinE6;
        private static Brooches _sinE7;
        private static Brooches _sinE8;
        private static Brooches _sinE9;
        private static Brooches _sinE10;

        #region

        private static void SetupSin()
        {
            #region Attack

            _sinA1 = new("猝死",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalRate, .05m)}},
                    {BroochesRare.Giga, new[] {CriticalRate004}},
                    {BroochesRare.Mega, new[] {CriticalRate003}},
                    {BroochesRare.Kilo, new[] {CriticalRate002}},
                    {BroochesRare.Byte, new[] {CriticalRate001}}
                });

            _sinA2 = new("暗殺",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate006, EvadeM30}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate004, EvadeM30}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate003, EvadeM30}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate002, EvadeM30}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate001, EvadeM30}}
                });

            _sinA3 = new("刺激者",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {SuperArmorBreakPowerRate006, HpRateM005}},
                    {BroochesRare.Giga, new[] {SuperArmorBreakPowerRate004, HpRateM005}},
                    {BroochesRare.Mega, new[] {SuperArmorBreakPowerRate003, HpRateM005}},
                    {BroochesRare.Kilo, new[] {SuperArmorBreakPowerRate002, HpRateM005}},
                    {BroochesRare.Byte, new[] {SuperArmorBreakPowerRate001, HpRateM005}}
                });

            _sinA4 = new("擦傷",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {AttackSpeedRate004, DefenseBreakRate002}},
                    {BroochesRare.Giga, new[] {AttackSpeedRate003, DefenseBreakRate001}},
                    {BroochesRare.Mega, new[] {AttackSpeedRate003}},
                    {BroochesRare.Kilo, new[] {AttackSpeedRate002}},
                    {BroochesRare.Byte, new[] {AttackSpeedRate001}}
                });

            _sinA5 = new("颱風",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {AttackSpeedRate004, ExtraDamageRateBoss002}},
                    {BroochesRare.Giga, new[] {AttackSpeedRate003, new(Static.ExtraDamageRateBoss, .01m)}},
                    {BroochesRare.Mega, new[] {AttackSpeedRate003}},
                    {BroochesRare.Kilo, new[] {AttackSpeedRate002}},
                    {BroochesRare.Byte, new[] {AttackSpeedRate001}}
                });

            _sinA6 = new("根除",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {new(Static.CriticalDamage, 980), HpRateM005}},
                    {BroochesRare.Giga, new[] {CriticalDamage560, HpRateM005}},
                    {BroochesRare.Mega, new[] {new(Static.CriticalDamage, 336), HpRateM005}},
                    {BroochesRare.Kilo, new[] {new(Static.CriticalDamage, 196), HpRateM005}},
                    {BroochesRare.Byte, new[] {new(Static.CriticalDamage, 98), HpRateM005}}
                });

            _sinA7 = new("魯莽",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new[] {DefenseBreakRate005, DefenseRateM005}},
                    {BroochesRare.Giga, new[] {DefenseBreakRate004, DefenseRateM005}},
                    {BroochesRare.Mega, new[] {DefenseBreakRate003, DefenseRateM005}},
                    {BroochesRare.Kilo, new[] {DefenseBreakRate002, DefenseRateM005}},
                    {BroochesRare.Byte, new[] {DefenseBreakRate001, DefenseRateM005}}
                });

            _sinA8 = new("清除",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalDamage, 756)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalDamage, 448)}},
                    {BroochesRare.Mega, new[] {CriticalDamage280}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.CriticalDamage, 168)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.CriticalDamage, 84)}}
                });

            _sinA9 = new("驅動",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackSpeedRateOCriticalHitP1D2, .05m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackSpeedRateOCriticalHitP1D2, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackSpeedRateOCriticalHitP1D2, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackSpeedRateOCriticalHitP1D2, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackSpeedRateOCriticalHitP1D2, .01m)}}
                });

            _sinA10 = new("酸性的",
                BroochesSeries.Sin,
                BroochesType.Attack,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOCriticalHitP1D2, 1_620)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOCriticalHitP1D2, 1_134)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOCriticalHitP1D2, 793)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOCriticalHitP1D2, 555)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOCriticalHitP1D2, 388)}}
                });

            #endregion

            #region Defense

            _sinD1 = new("躲藏",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.Evade, 130)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.Evade, 91)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.Evade, 63)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.Evade, 44)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.Evade, 30)}}
                });

            _sinD2 = new("油漆",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackSpeedRateOSufferCriticalP5D2, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackSpeedRateOSufferCriticalP5D2, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackSpeedRateOSufferCriticalP5D2, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackSpeedRateOSufferCriticalP5D2, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackSpeedRateOSufferCriticalP5D2, .01m)}}
                });

            _sinD3 = new("分身",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOSufferCriticalP5D2, 1_560)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOSufferCriticalP5D2, 960)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOSufferCriticalP5D2, 600)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOSufferCriticalP5D2, 360)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOSufferCriticalP5D2, 180)}}
                });

            _sinD4 = new("煙霧",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalRateOUseAvoidP1D5, .12m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalRateOUseAvoidP1D5, .09m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalRateOUseAvoidP1D5, .06m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalRateOUseAvoidP1D5, .04m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalRateOUseAvoidP1D5, .01m)}}
                });

            _sinD5 = new("逃避",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOUseAvoidP1D5, 1_723)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOUseAvoidP1D5, 1_060)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOUseAvoidP1D5, 663)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOUseAvoidP1D5, 397)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOUseAvoidP1D5, 162)}}
                });

            _sinD6 = new("預防",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.CriticalResistanceRate, .1m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.CriticalResistanceRate, .08m)}},
                    {BroochesRare.Mega, new[] {CriticalResistanceRate004}},
                    {BroochesRare.Kilo, new[] {CriticalResistanceRate003}},
                    {BroochesRare.Byte, new[] {CriticalResistanceRate002}}
                });

            _sinD7 = new("流動",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackSpeedRateOSufferP3D15M, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackSpeedRateOSufferP3D15M, .04m)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackSpeedRateOSufferP3D15M, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackSpeedRateOSufferP3D15M, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackSpeedRateOSufferP3D15M, .01m)}}
                });

            _sinD8 = new("打斷",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(EvadeOSufferP4D3, 180)}},
                    {BroochesRare.Giga, new Effect[] {new(EvadeOSufferP4D3, 126)}},
                    {BroochesRare.Mega, new Effect[] {new(EvadeOSufferP4D3, 88)}},
                    {BroochesRare.Kilo, new Effect[] {new(EvadeOSufferP4D3, 61)}},
                    {BroochesRare.Byte, new Effect[] {new(EvadeOSufferP4D3, 42)}}
                });

            _sinD9 = new("影子步伐",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalRateOAvoidP3D2, .14m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalRateOAvoidP3D2, .1m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalRateOAvoidP3D2, .05m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalRateOAvoidP3D2, .03m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalRateOAvoidP3D2, .01m)}}
                });

            _sinD10 = new("後退步伐",
                BroochesSeries.Sin,
                BroochesType.Defense,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOSufferP5D3, 1_930)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOSufferP5D3, 1_351)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOSufferP5D3, 945)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOSufferP5D3, 661)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOSufferP5D3, 463)}}
                });

            #endregion

            #region Effect

            _sinE1 = new("飛鼠裝",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(Static.MoveSpaceRateBattle, .07m)}},
                    {BroochesRare.Giga, new Effect[] {new(Static.MoveSpaceRateBattle, .05m)}},
                    {BroochesRare.Mega, new Effect[] {new(Static.MoveSpaceRateBattle, .03m)}},
                    {BroochesRare.Kilo, new Effect[] {new(Static.MoveSpaceRateBattle, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(Static.MoveSpaceRateBattle, .01m)}}
                });

            _sinE2 = new("貓眼",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOUseSkillP5D5, 2_200)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOUseSkillP5D5, 1_600)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOUseSkillP5D5, 1_100)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOUseSkillP5D5, 650)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOUseSkillP5D5, 300)}}
                });

            _sinE3 = new("鷹眼",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageORunP2D3, 1_760)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageORunP2D3, 1_232)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageORunP2D3, 862)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageORunP2D3, 603)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageORunP2D3, 422)}}
                });

            _sinE4 = new("追捕",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalRateORunP3D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalRateORunP3D5, .06m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalRateORunP3D5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalRateORunP3D5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalRateORunP3D5, .01m)}}
                });

            _sinE5 = new("血腥斗篷",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalRateOUseSkillP5D5, .08m)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalRateOUseSkillP5D5, .06m)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalRateOUseSkillP5D5, .04m)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalRateOUseSkillP5D5, .02m)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalRateOUseSkillP5D5, .01m)}}
                });

            _sinE6 = new("每週標記",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOSufferStamina50UpD5, 550)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOSufferStamina50UpD5, 385)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOSufferStamina50UpD5, 269)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOSufferStamina50UpD5, 188)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOSufferStamina50UpD5, 131)}}
                });

            _sinE7 = new("噬血",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(HpRecoveryOSufferStamina50Up, 140)}},
                    {BroochesRare.Giga, new Effect[] {new(HpRecoveryOSufferStamina50Up, 100)}},
                    {BroochesRare.Mega, new Effect[] {new(HpRecoveryOSufferStamina50Up, 70)}},
                    {BroochesRare.Kilo, new Effect[] {new(HpRecoveryOSufferStamina50Up, 40)}},
                    {BroochesRare.Byte, new Effect[] {new(HpRecoveryOSufferStamina50Up, 20)}}
                });

            _sinE8 = new("斷頭台",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(CriticalDamageOUseItemP2D5, 1_250)}},
                    {BroochesRare.Giga, new Effect[] {new(CriticalDamageOUseItemP2D5, 875)}},
                    {BroochesRare.Mega, new Effect[] {new(CriticalDamageOUseItemP2D5, 612)}},
                    {BroochesRare.Kilo, new Effect[] {new(CriticalDamageOUseItemP2D5, 428)}},
                    {BroochesRare.Byte, new Effect[] {new(CriticalDamageOUseItemP2D5, 299)}}
                });

            _sinE9 = new("瘋狂",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOUseItemP2D5, 936)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOUseItemP2D5, 655)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOUseItemP2D5, 458)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOUseItemP2D5, 320)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOUseItemP2D5, 224)}}
                });

            _sinE10 = new("技術",
                BroochesSeries.Sin,
                BroochesType.Effect,
                new Dictionary<BroochesRare, IReadOnlyCollection<Effect>>
                {
                    {BroochesRare.Tera, new Effect[] {new(AttackOCriticalHitP1D5, 760)}},
                    {BroochesRare.Giga, new Effect[] {new(AttackOCriticalHitP1D5, 532)}},
                    {BroochesRare.Mega, new Effect[] {new(AttackOCriticalHitP1D5, 372)}},
                    {BroochesRare.Kilo, new Effect[] {new(AttackOCriticalHitP1D5, 260)}},
                    {BroochesRare.Byte, new Effect[] {new(AttackOCriticalHitP1D5, 182)}}
                });

            #endregion
        }

        #endregion
    }
}