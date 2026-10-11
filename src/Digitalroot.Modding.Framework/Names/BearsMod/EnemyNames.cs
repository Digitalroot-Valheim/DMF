using JetBrains.Annotations;
using System.Collections.Generic;
using Digitalroot.Modding.Framework.Utils;

// ReSharper disable MemberCanBePrivate.Global

namespace Digitalroot.Modding.Framework.Names.BearsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    [UsedImplicitly]
    public static readonly IEnumerable<string> AllNames = ReflectionUtils.AllNames(typeof(EnemyNames));

    public static readonly string Bear = PrefabNames.Bear;
    public static readonly string BearCub = PrefabNames.BearCub;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Mountain:
        case Heightmap.Biome.DeepNorth:
          yield return Bear;
          yield return BearCub;
          break;
      }
    }
  }
}
