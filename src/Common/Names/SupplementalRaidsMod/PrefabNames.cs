using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable StringLiteralTypo

namespace DMF.Common.Names.SupplementalRaidsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    private const string PrefixM = "RRRM_";
    private const string PrefixNpc = "RRRN_";
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string DeathsquitoT1 = $"{PrefixM}{nameof(DeathsquitoT1)}";
    public static readonly string EikthyrBoar = $"{PrefixM}{nameof(EikthyrBoar)}";
    public static readonly string EikthyrLox = $"{PrefixM}{nameof(EikthyrLox)}";
    public static readonly string EikthyrNeck = $"{PrefixM}{nameof(EikthyrNeck)}";
    public static readonly string EikthyrNeckT3M = $"{PrefixM}{nameof(EikthyrNeckT3M)}";
    public static readonly string EikthyrNeckT3R = $"{PrefixM}{nameof(EikthyrNeckT3R)}";
    public static readonly string EikthyrNeckT4 = $"{PrefixM}{nameof(EikthyrNeckT4)}";
    public static readonly string EikthyrWolf = $"{PrefixM}{nameof(EikthyrWolf)}";

    // ReSharper disable InconsistentNaming
    public static readonly string GDBurningTorch = $"{PrefixM}{nameof(GDBurningTorch)}";
    public static readonly string GDElderBrute = $"{PrefixM}{nameof(GDElderBrute)}";
    public static readonly string GDTosser = $"{PrefixM}{nameof(GDTosser)}";

    public static readonly string GDVileHand = $"{PrefixM}{nameof(GDVileHand)}";
    // ReSharper restore InconsistentNaming

    public static readonly string MountainBandit1 = $"{PrefixNpc}mountainbandit1";
    public static readonly string MountainBandit2 = $"{PrefixNpc}mountainbandit2";
    public static readonly string MountainBandit3 = $"{PrefixNpc}mountainbandit3";
    public static readonly string PlainsBandit1 = $"{PrefixNpc}plainsbandit1";
    public static readonly string PlainsBandit2 = $"{PrefixNpc}plainsbandit2";
    public static readonly string PlainsBandit3 = $"{PrefixNpc}plainsbandit3";
    public static readonly string TrollT1M = $"{PrefixM}{nameof(TrollT1M)}";
    public static readonly string TrollT1R = $"{PrefixM}{nameof(TrollT1R)}";
    public static readonly string TrollT2Elite = $"{PrefixM}{nameof(TrollT2Elite)}";
    public static readonly string TrollT3Elite = $"{PrefixM}{nameof(TrollT3Elite)}";
    public static readonly string TrollT4Elite = $"{PrefixM}{nameof(TrollT4Elite)}";

    // ReSharper disable once IdentifierTypo
    public static readonly string UndeadHrungnir = $"{PrefixM}{nameof(UndeadHrungnir)}";
    public static readonly string SkeletonT1 = $"{PrefixM}{nameof(SkeletonT1)}";
    public static readonly string SkeletonT2M = $"{PrefixM}{nameof(SkeletonT2M)}";
    public static readonly string SkeletonT2R = $"{PrefixM}{nameof(SkeletonT2R)}";
    public static readonly string SkeletonT3Captain = $"{PrefixM}{nameof(SkeletonT3Captain)}";
    public static readonly string SkeletonT3R = $"{PrefixM}{nameof(SkeletonT3R)}";
    public static readonly string SkeletonT3M = $"{PrefixM}{nameof(SkeletonT3M)}";
    public static readonly string SkeletonT4Captain = $"{PrefixM}{nameof(SkeletonT4Captain)}";
    public static readonly string SkeletonT4M = $"{PrefixM}{nameof(SkeletonT4M)}";
    public static readonly string SkeletonT4MageFire = $"{PrefixM}{nameof(SkeletonT4MageFire)}";
    public static readonly string SkeletonT4MageIce = $"{PrefixM}{nameof(SkeletonT4MageIce)}";
    public static readonly string SkeletonT5M = $"{PrefixM}{nameof(SkeletonT5M)}";
    public static readonly string WildBandit1 = $"{PrefixNpc}wildbandit1";
    public static readonly string WildBandit2 = $"{PrefixNpc}wildbandit2";
    public static readonly string WildBandit3 = $"{PrefixNpc}wildbandit3";
    public static readonly string WildBandit4Giant = $"{PrefixNpc}wildbanditgiant";
    public static readonly string WraithT1 = $"{PrefixM}{nameof(WraithT1)}";
    public static readonly string WraithT2 = $"{PrefixM}{nameof(WraithT2)}";
    public static readonly string WraithT3 = $"{PrefixM}{nameof(WraithT3)}";
  }
}
