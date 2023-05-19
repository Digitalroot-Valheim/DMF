using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.SupplementalRaidsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));
    public static readonly string DeathsquitoT1 = PrefabNames.DeathsquitoT1;
    public static readonly string EikthyrBoar = PrefabNames.EikthyrBoar;
    public static readonly string EikthyrNeck = PrefabNames.EikthyrNeck;
    public static readonly string EikthyrNeckT3R = PrefabNames.EikthyrNeckT3R;
    public static readonly string EikthyrWolf = PrefabNames.EikthyrWolf;

    // ReSharper disable once InconsistentNaming
    public static readonly string GDTosser = PrefabNames.GDTosser;
    public static readonly string MountainBandit1 = PrefabNames.MountainBandit1;
    public static readonly string MountainBandit2 = PrefabNames.MountainBandit2;
    public static readonly string PlainsBandit1 = PrefabNames.PlainsBandit1;
    public static readonly string PlainsBandit2 = PrefabNames.PlainsBandit2;
    public static readonly string TrollT1M = PrefabNames.TrollT1M;
    public static readonly string TrollT1R = PrefabNames.TrollT1R;
    public static readonly string SkeletonT1 = PrefabNames.SkeletonT1;
    public static readonly string SkeletonT2M = PrefabNames.SkeletonT2M;
    public static readonly string SkeletonT2R = PrefabNames.SkeletonT2R;
    public static readonly string SkeletonT3R = PrefabNames.SkeletonT3R;
    public static readonly string SkeletonT3M = PrefabNames.SkeletonT3M;
    public static readonly string SkeletonT4M = PrefabNames.SkeletonT4M;
    public static readonly string SkeletonT4MageFire = PrefabNames.SkeletonT4MageFire;
    public static readonly string SkeletonT4MageIce = PrefabNames.SkeletonT4MageIce;
    public static readonly string SkeletonT5M = PrefabNames.SkeletonT5M;
    public static readonly string WildBandit1 = PrefabNames.WildBandit1;
    public static readonly string WildBandit2 = PrefabNames.WildBandit2;
    public static readonly string WraithT1 = PrefabNames.WraithT1;
    public static readonly string WraithT2 = PrefabNames.WraithT2;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return EikthyrBoar;
          yield return EikthyrWolf;
          yield return EikthyrNeck;
          yield return EikthyrNeckT3R;
          yield return WildBandit1;
          yield return WildBandit2;
          break;

        case Heightmap.Biome.BlackForest:
          yield return TrollT1R;
          yield return TrollT1M;
          yield return GDTosser;
          yield return SkeletonT1;
          yield return SkeletonT2R;
          yield return SkeletonT2M;
          break;

        case Heightmap.Biome.Swamp:
          yield return SkeletonT3R;
          yield return SkeletonT3M;
          yield return SkeletonT4M;
          yield return SkeletonT4MageFire;
          yield return SkeletonT4MageIce;
          yield return SkeletonT5M;
          yield return WraithT1;
          yield return WraithT2;
          break;

        case Heightmap.Biome.Mountain:
          yield return MountainBandit1;
          yield return MountainBandit2;
          break;

        case Heightmap.Biome.Plains:
          yield return DeathsquitoT1;
          yield return PlainsBandit1;
          yield return PlainsBandit2;
          break;


        case Heightmap.Biome.AshLands:
          yield return SkeletonT4MageFire;
          break;

        case Heightmap.Biome.DeepNorth:
          yield return SkeletonT4MageIce;
          break;
      }
    }
  }
}
