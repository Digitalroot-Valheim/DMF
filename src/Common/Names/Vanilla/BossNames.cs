using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.Vanilla
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class BossNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(BossNames));
    public static readonly string Eikthyr = PrefabNames.Eikthyr;
    public static readonly string TheElder = PrefabNames.GdKing;
    public static readonly string Bonemass = PrefabNames.Bonemass;
    public static readonly string Moder = PrefabNames.Dragon;
    public static readonly string Yagluth = PrefabNames.GoblinKing;
    public static readonly string SeekerQueen = PrefabNames.SeekerQueen;
    public static readonly string DvergrBoss = PrefabNames.DgDvergrBoss;

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
          yield return DvergrBoss;
          break;
      }
    }
  }
}
