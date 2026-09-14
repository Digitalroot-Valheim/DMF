using JetBrains.Annotations;
using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;

// ReSharper disable MemberCanBePrivate.Global

namespace Digitalroot.Modding.Framework.Names.MonsterLabZMod
{
  public static partial class BossNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(BossNames));

    public static readonly string Kraken = PrefabNames.Kraken;
    // ReSharper disable once InconsistentNaming
    public static readonly string KrakenLD = PrefabNames.KrakenLD;
    public static readonly string SpiderBoss = PrefabNames.SpiderBoss;

    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Mistlands:
          yield return SpiderBoss;
          break;

        case Heightmap.Biome.Ocean:
          yield return Kraken;
          yield return KrakenLD;
          break;
      }
    }
  }
}
