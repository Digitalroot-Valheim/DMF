using JetBrains.Annotations;
using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;
// ReSharper disable MemberCanBePrivate.Global

namespace Digitalroot.Modding.Framework.Names.Vanilla
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class BossNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(BossNames));
    public static readonly string Eikthyr = PrefabNames.Eikthyr;
    public static readonly string TheElder = PrefabNames.GdKing;
    public static readonly string Bonemass = PrefabNames.Bonemass;
    public static readonly string Moder = PrefabNames.Dragon;
    public static readonly string Yagluth = PrefabNames.GoblinKing;
    public static readonly string SeekerQueen = PrefabNames.SeekerQueen;
    public static readonly string DragonQueen = PrefabNames.Dragonqueen;
    public static readonly string Fader = PrefabNames.Fader; // Boss??

    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return Eikthyr;
          break;
        case Heightmap.Biome.Swamp:
          yield return Bonemass;
          break;
        case Heightmap.Biome.Mountain:
          yield return Moder;
          break;
        case Heightmap.Biome.BlackForest:
          yield return TheElder;
          break;
        case Heightmap.Biome.Plains:
          yield return Yagluth;
          break;
        case Heightmap.Biome.Mistlands:
          yield return SeekerQueen;
          break;
      }
    }
  }
}
