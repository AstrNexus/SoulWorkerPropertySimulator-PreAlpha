﻿using System.Collections.Generic;
using SoulWorkerPropertySimulator.Models;

namespace SoulWorkerPropertySimulator.Data
{
    internal static class BroochesData
    {
        private static readonly BroochesClassify       SdTera  = new(BroochesSeries.Sd, BroochesRare.Tera);
        private static readonly BroochesClassify       BskTera = new(BroochesSeries.Bsk, BroochesRare.Tera);
        private static readonly BroochesClassify       FotTera = new(BroochesSeries.Fot, BroochesRare.Tera);
        private static readonly BroochesClassify       SinTera = new(BroochesSeries.Sin, BroochesRare.Tera);
        private static          ICollection<Brooches>? _Brooches;

        internal static ICollection<Brooches> Get()
        {
            if (_Brooches != null) { return _Brooches; }

            return _Brooches = new List<Brooches>
            {
                new("鷹眼",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.Accuracy), 52)}),
                new("致命",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalDamage), 700)}),
                new("破碎",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.SuperArmorBreakPowerRate), 10)}),
                new("熔解",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.DefenseBreakRate), 5)}),
                new("屠殺",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateBoss), 5)}),
                new("獨輪",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateBasic), 5)}),
                new("突擊",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRateOriginal), 36)}),
                new("攻擊者",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.Attack), 405)}),
                new("碎片",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.PartialDamageRate), .2m)}),
                new("燃燒",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRate, Opportunity.Hit, .03m, 3), 24)}),
                new("過熱",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRate, Opportunity.Hit, .01m, 5), 45)}),
                new("刺穿",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate, Opportunity.Critical, .05m, 3), 6)
                    }),
                new("滲透",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate, Opportunity.Critical, .03m, 5), 10)
                    }),
                new("黃蜂",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateAir), 20)}),
                new("踐踏",
                    BroochesType.Attack,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateFall), 20)}),
                new("盔甲",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRateOriginal), 54)}),
                new("受傷",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalResistanceRate), 6)}),
                new("模糊",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.Evade), 52)}),
                new("幽靈",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.Avoid, Duration: 5), 5)
                    }),
                new("巨人",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.DamageReductionRateBasic), 7)}),
                new("鸚螺",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.DamageReductionRateBoss), 5)}),
                new("麻雀",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.AirSuffer, Duration: 5),
                            7)
                    }),
                new("地殼",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.Fall, Duration: 5), 7)
                    }),
                new("幻象",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.Evade, Opportunity.Suffer, .15m, 3), 270)}),
                new("幻影",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.PartialDamageRate, Opportunity.Avoid, .1m, 10), 30)
                    }),
                new("巨魔",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRecovery, Opportunity.SufferCritical, Duration: 50),
                            2500)
                    }),
                new("生命",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.HPRate), 12)}),
                new("活力",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.StaminaRecovery), 8)}),
                new("屏障",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.DamageReductionRate), 5)}),
                new("石像",
                    BroochesType.Defense,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseRate, Opportunity.SufferHP50Down, .1m, 5), 50)
                    }),
                new("吸血",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.HPRecovery, Opportunity.Kill), 600)}),
                new("迅猛",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Hit, .05m, 5), 25)
                    }),
                new("行軍",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRateTown), 6)}),
                new("鋼鐵",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.SufferBoss, .1m, 5), 10)
                    }),
                new("搖擺",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRate, Opportunity.Avoid), 70)}),
                new("救濟",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.HPRecovery, Opportunity.Avoid, .1m), 1500)}),
                new("吸收",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.StaminaRecovery, Opportunity.Hit, .02m), 10)}),
                new("迅速",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRate), 5)}),
                new("硬度",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseRate, Opportunity.Suffer, .15m, 5), 70)
                    }),
                new("藐視",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalResistanceRate, Opportunity.Suffer, .08m, 10),
                            12)
                    }),
                new("固執",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.EndureSecond, Opportunity.Suffer, .2m), 12)}),
                new("刺蝟",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.MoveSpaceRate, Opportunity.Suffer, .2m, 6), 12)
                    }),
                new("喜悅",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRecoveryRate, Opportunity.Avoid, 5), 15),
                        new(new EffectContext(Property.HPRecoveryRate), 5)
                    }),
                new("行者",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRate, Opportunity.Run, .15m, 5), 7)}),
                new("啟蒙",
                    BroochesType.Effect,
                    SdTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CooldownShorterRate, Opportunity.UseSkill, .02m), 10)
                    }),
                new("鷹眼",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Accuracy), 52)}),
                new("飛行",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateAir), 20)}),
                new("致命",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalDamage), 700)}),
                new("阻礙",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.ExtraDamageRateFall), 20)}),
                new("破碎",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.SuperArmorBreakPowerRate), 10)}),
                new("熔解",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.DefenseBreakRate), 5)}),
                new("攻擊",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Attack), 216)}),
                new("碎片",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.PartialDamageRate, Opportunity.PartialDamage), 20)
                    }),
                new("灰熊",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackRate), 48),
                        new(new EffectContext(Property.DefenseRate), -5)
                    }),
                new("瘋狂",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackRate), 38),
                        new(new EffectContext(Property.Evade), -30)
                    }),
                new("捨身",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackRate), 38),
                        new(new EffectContext(Property.HPRate), -5)
                    }),
                new("搏擊",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Accuracy), 90),
                        new(new EffectContext(Property.DefenseRate), -5)
                    }),
                new("野豬",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Accuracy), 90),
                        new(new EffectContext(Property.Evade), -30)
                    }),
                new("老虎",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Accuracy), 90),
                        new(new EffectContext(Property.HPRate), -5)
                    }),
                new("黑蛇",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate), 9),
                        new(new EffectContext(Property.DefenseRate), -5)
                    }),
                new("海怪",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate), 9),
                        new(new EffectContext(Property.Evade), -30)
                    }),
                new("麋鹿",
                    BroochesType.Attack,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate), 9),
                        new(new EffectContext(Property.HPRate), -5)
                    }),
                new("盔甲",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.DefenseRate), 25)}),
                new("模糊",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Evade), 42)}),
                new("幽靈",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.Avoid, Duration: 5), 9)
                    }),
                new("巨人",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.DamageReductionRate), 9)}),
                new("鸚螺",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.DamageReductionRateBoss), 5)}),
                new("麻雀",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.AirHit, Duration: 5),
                            10)
                    }),
                new("地殼",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate,
                                Opportunity.FallSuffer,
                                Duration: 5),
                            10)
                    }),
                new("狂暴",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.Suffer, .3m, 5), 1080)}),
                new("恐懼",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Accuracy, Opportunity.Suffer, .3m, 5), 350)}),
                new("欺騙",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.Suffer, .3m, 5), 1500)
                    }),
                new("發狂",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.PartialDamageRate, Opportunity.Suffer, .3m, 5), 50)
                    }),
                new("死神",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Suffer, .3m, 5),
                            50)
                    }),
                new("激怒",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.Avoid, .3m, 5), 1200)}),
                new("鐵桿",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Accuracy, Opportunity.Avoid, .3m, 5), 20)}),
                new("犀牛",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.Avoid, .3m, 5), 2400)
                    }),
                new("憤怒",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.PartialDamageRate, Opportunity.Avoid, .3m, 5), 50)
                    }),
                new("小鬼",
                    BroochesType.Defense,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Avoid, .3m, 5), 21)
                    }),
                new("固執",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.EndureSecond, Opportunity.Suffer, .2m), 12)}),
                new("迅猛",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Hit, .05m, 5), 21)
                    }),
                new("行軍",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRateTown), 6)}),
                new("鋼鐵",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.SufferBoss, .1m, 5), 8)
                    }),
                new("搖擺",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.AttackRateNext, Opportunity.Avoid), 56)}),
                new("救濟",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.HPRecovery, Opportunity.Avoid, .1m), 2500)}),
                new("藐視",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalResistanceRate, Opportunity.Suffer, .08m, 10),
                            12)
                    }),
                new("迅速",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRate), 5)}),
                new("發熱",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.UseSkill, .1m, 5), 1350)}),
                new("恢復",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Accuracy, Opportunity.UseSkill, .1m, 5), 350)
                    }),
                new("沉重",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.UseSkill, .03m, 5), 3000)
                    }),
                new("劍聖",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.Run, .3m, 5), 450)}),
                new("餅乾",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Run, .1m, 5), 10)
                    }),
                new("充電",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate, Opportunity.Run, .1m, 5), 10)
                    }),
                new("狂亂",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Attack, Opportunity.Kill, Duration: 5), 1225)
                    }),
                new("狂人",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate, Opportunity.Kill, Duration: 5),
                            16)
                    }),
                new("感覺",
                    BroochesType.Effect,
                    BskTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate, Opportunity.Kill, Duration: 5), 16)
                    }),
                new("燃料庫",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate), 5),
                        new(new EffectContext(Property.Evade), -45)
                    }),
                new("投石器",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate), 5),
                        new(new EffectContext(Property.Accuracy), -45)
                    }),
                new("發射器",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage), 720),
                        new(new EffectContext(Property.Accuracy), -25)
                    }),
                new("閃電戰",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage), 720),
                        new(new EffectContext(Property.Evade), -38)
                    }),
                new("加農",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Attack), 600),
                        new(new EffectContext(Property.Accuracy), -25)
                    }),
                new("佔領",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Attack), 600),
                        new(new EffectContext(Property.Evade), -38)
                    }),
                new("支配",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalRate), 8),
                        new(new EffectContext(Property.Evade), -38)
                    }),
                new("游擊隊",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.Critical, Duration: 3), 870)
                    }),
                new("勇氣",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.HP30Down, Duration: 3), 1260)
                    }),
                new("大將",
                    BroochesType.Attack,
                    FotTera,
                    new List<Effect> {new(new EffectContext(Property.HPRecovery, Opportunity.Hit, .15m), 320)}),
                new("戰壕",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Defense), 720),
                        new(new EffectContext(Property.MoveSpaceRate), -1)
                    }),
                new("危城",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Defense), 720),
                        new(new EffectContext(Property.AttackSpeedRate), -1)
                    }),
                new("防禦",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Defense), 720),
                        new(new EffectContext(Property.Accuracy), -30)
                    }),
                new("地圖",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRate), 15),
                        new(new EffectContext(Property.MoveSpaceRate), -1)
                    }),
                new("堡壘",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRate), 15),
                        new(new EffectContext(Property.AttackSpeedRate), -1)
                    }),
                new("停留",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRate), 15),
                        new(new EffectContext(Property.Accuracy), -30)
                    }),
                new("堅固的",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRate), 15), new(new EffectContext(Property.Evade), -50)
                    }),
                new("摩擦",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate, Opportunity.Suffer, .3m), 1000)
                    }),
                new("穩固",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Defense, Opportunity.HP50Down, Duration: 10), 770)
                    }),
                new("休戰",
                    BroochesType.Defense,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalResistanceRate,
                                Opportunity.HP50Down,
                                Duration: 10),
                            27)
                    }),
                new("掃蕩",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect> {new(new EffectContext(Property.Defense, Opportunity.Run, .1m, 5), 400)}),
                new("戰術",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Attack, Opportunity.Kill, Duration: 5), 1200)
                    }),
                new("防護",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.Defense, Opportunity.Kill, Duration: 5), 850)
                    }),
                new("撤退",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRecoveryRate, Opportunity.UseAvoid, .1m), 15)
                    }),
                new("疏散",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DamageReductionRate, Opportunity.Kill, Duration: 5), 12)
                    }),
                new("狙擊",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SoulGateRecoveryRate, Opportunity.UseSkill, .1m), 15)
                    }),
                new("打擾",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect> {new(new EffectContext(Property.Defense, Opportunity.Suffer, .05m, 10), 150)}),
                new("偵察",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.Hit, .1m, 5), 400)}),
                new("對策",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.InvincibleSecond, Opportunity.HitWhenHP20Down, .1m),
                            1.5m)
                    }),
                new("保護",
                    BroochesType.Effect,
                    FotTera,
                    new List<Effect> {new(new EffectContext(Property.Defense, Opportunity.UseSkill, .1m, 5), 800)}),
                new("猝死",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalRate), 5)}),
                new("暗殺",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate), 6),
                        new(new EffectContext(Property.Evade), -30)
                    }),
                new("刺激者",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.SuperArmorBreakPowerRate), 6),
                        new(new EffectContext(Property.HPRate), -5)
                    }),
                new("擦傷",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate), 4),
                        new(new EffectContext(Property.DefenseBreakRate), 2)
                    }),
                new("颱風",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate), 4),
                        new(new EffectContext(Property.ExtraDamageRateBoss), 2)
                    }),
                new("根除",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage), 980),
                        new(new EffectContext(Property.HPRate), -5)
                    }),
                new("魯莽",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.DefenseBreakRate), 5),
                        new(new EffectContext(Property.DefenseRate), -5)
                    }),
                new("清除",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalDamage), 756)}),
                new("驅動",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate, Opportunity.CriticalHit, .1m, 2), 5)
                    }),
                new("酸性的",
                    BroochesType.Attack,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.CriticalHit, .1m, 2), 1620)
                    }),
                new("躲藏",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.Evade), 130)}),
                new("油漆",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate, Opportunity.SufferCritical, .5m, 2), 12)
                    }),
                new("分身",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.SufferCritical, .5m, 2),
                            1560)
                    }),
                new("煙霧",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalRate, Opportunity.UseAvoid, .1m, 5), 12)
                    }),
                new("逃避",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.UseAvoid, .1m, 5), 1723)
                    }),
                new("預防",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalResistanceRate), 10)}),
                new("流動",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.AttackSpeedRate, Opportunity.Suffer, .3m, 1.5m), 7)
                    }),
                new("打斷",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.Evade, Opportunity.Suffer, .4m, 3), 180)}),
                new("影子步伐",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalRate, Opportunity.Avoid, .3m, 2), 14)
                    }),
                new("後退步伐",
                    BroochesType.Defense,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.Suffer, .5m, 3), 1930)
                    }),
                new("飛鼠裝",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.MoveSpaceRate), 7)}),
                new("貓眼",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.UseSkill, .05m, 5), 2200)
                    }),
                new("鷹眼",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.Run, .2m, 3), 1760)
                    }),
                new("追捕",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.CriticalRate, Opportunity.Run, .3m, 5), 8)}),
                new("血腥斗篷",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalRate, Opportunity.UseSkill, .05m, 5), 8)
                    }),
                new("每週標記",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage,
                                Opportunity.SufferStamina50Up,
                                Duration: 5),
                            550)
                    }),
                new("噬血",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.HPRecovery, Opportunity.SufferStamina50Up), 140)
                    }),
                new("斷頭台",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect>
                    {
                        new(new EffectContext(Property.CriticalDamage, Opportunity.UseItem, .2m, 5), 1250)
                    }),
                new("瘋狂",
                    BroochesType.Effect,
                    SinTera,
                    new List<Effect> {new(new EffectContext(Property.Attack, Opportunity.UseItem, .2m, 5), 936)})
            };
        }
    }
}