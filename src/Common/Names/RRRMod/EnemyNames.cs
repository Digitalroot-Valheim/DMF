using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.RRRMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));
    public static readonly string TrollTosser = PrefabNames.TrollTosser;
    // ReSharper disable once InconsistentNaming
    public static readonly string GDThornweaver = PrefabNames.GDThornweaver;
    public static readonly string GhostVengeful = PrefabNames.GhostVengeful;
    public static readonly string Grig = PrefabNames.Grig;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.BlackForest:
          yield return TrollTosser;
          yield return GDThornweaver;
          break;

        case Heightmap.Biome.Swamp:
          yield return GhostVengeful;
          break;

        case Heightmap.Biome.Mistlands:
          yield return Grig;
          break;
      }
    }
  }
}
