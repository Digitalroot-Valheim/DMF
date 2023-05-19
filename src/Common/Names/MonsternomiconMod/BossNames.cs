using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.MonsternomiconMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class BossNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(BossNames));
    public static readonly string BlazingDamnedOne = PrefabNames.BlazingDamnedOne;
    public static readonly string DamnedOne = PrefabNames.DamnedOne;
    public static readonly string DevourerFenring = PrefabNames.DevourerFenring;
    public static readonly string ForgottenOne = PrefabNames.ForgottenOne;
    public static readonly string Jotunn = PrefabNames.Jotunn;
    public static readonly string MotherDarkSpider = PrefabNames.MotherDarkSpider;
    public static readonly string StormFenring = PrefabNames.StormFenring;
    public static readonly string SvartalfrQueen = PrefabNames.SvartalfrQueen;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
        case Heightmap.Biome.BlackForest:
        case Heightmap.Biome.Swamp:
        case Heightmap.Biome.Mountain:
          yield return StormFenring;
          break;

        case Heightmap.Biome.Mistlands:
          yield return DamnedOne;
          yield return MotherDarkSpider;
          yield return SvartalfrQueen;
          break;

        case Heightmap.Biome.AshLands:
          yield return BlazingDamnedOne;
          yield return DamnedOne;
          break;

        case Heightmap.Biome.DeepNorth:
          yield return DevourerFenring;
          yield return ForgottenOne;
          yield return Jotunn;
          break;
      }
    }

  }
}
