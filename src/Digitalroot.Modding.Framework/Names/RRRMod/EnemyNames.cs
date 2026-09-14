using JetBrains.Annotations;
using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;

// ReSharper disable MemberCanBePrivate.Global

namespace Digitalroot.Modding.Framework.Names.RRRMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(EnemyNames));
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
