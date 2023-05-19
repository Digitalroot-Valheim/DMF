using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.SupplementalRaidsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class BossNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(BossNames));
    public static readonly string EikthyrLox = PrefabNames.EikthyrLox;
    public static readonly string EikthyrNeckT3M = PrefabNames.EikthyrNeckT3M;
    public static readonly string EikthyrNeckT4 = PrefabNames.EikthyrNeckT4;

    // ReSharper disable InconsistentNaming
    public static readonly string GDBurningTorch = PrefabNames.GDBurningTorch;
    public static readonly string GDElderBrute = PrefabNames.GDElderBrute;

    public static readonly string GDVileHand = PrefabNames.GDVileHand;
    // ReSharper restore InconsistentNaming

    public static readonly string MountainBandit3 = PrefabNames.MountainBandit3;
    public static readonly string PlainsBandit3 = PrefabNames.PlainsBandit3;
    public static readonly string TrollT2Elite = PrefabNames.TrollT2Elite;
    public static readonly string TrollT3Elite = PrefabNames.TrollT3Elite;
    public static readonly string TrollT4Elite = PrefabNames.TrollT4Elite;

    // ReSharper disable once IdentifierTypo
    public static readonly string UndeadHrungnir = PrefabNames.UndeadHrungnir;
    public static readonly string SkeletonT3Captain = PrefabNames.SkeletonT3Captain;
    public static readonly string SkeletonT4Captain = PrefabNames.SkeletonT4Captain;
    public static readonly string WildBandit3 = PrefabNames.WildBandit3;
    public static readonly string WildBandit4Giant = PrefabNames.WildBandit4Giant;
    public static readonly string WraithT3 = PrefabNames.WraithT3;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return EikthyrLox;
          yield return EikthyrNeckT3M;
          yield return EikthyrNeckT4;
          yield return WildBandit3;
          yield return WildBandit4Giant;
          break;

        case Heightmap.Biome.BlackForest:
          yield return WildBandit3;
          yield return WildBandit4Giant;
          yield return TrollT2Elite;
          yield return TrollT3Elite;
          yield return TrollT4Elite;
          yield return GDElderBrute;
          yield return GDBurningTorch;
          yield return GDVileHand;
          break;

        case Heightmap.Biome.Swamp:
          yield return UndeadHrungnir;
          yield return SkeletonT3Captain;
          yield return SkeletonT4Captain;
          yield return WraithT3;
          break;

        case Heightmap.Biome.Mountain:
          yield return MountainBandit3;
          break;

        case Heightmap.Biome.Plains:
          yield return PlainsBandit3;
          break;
      }
    }
  }
}
