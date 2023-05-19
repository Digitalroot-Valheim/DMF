using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.MonsterLabZMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));

    public static readonly string BlackSpider = PrefabNames.BlackSpider;
    public static readonly string BrownSpider = PrefabNames.BrownSpider;
    public static readonly string FireGolem = PrefabNames.FireGolem;
    public static readonly string ForestSpider = PrefabNames.ForestSpider;
    public static readonly string FrigidSpider = PrefabNames.FrigidSpider;
    public static readonly string FrostSpider = PrefabNames.FrostSpider;
    public static readonly string GhostWarrior = PrefabNames.GhostWarrior;
    public static readonly string GoblinBase = PrefabNames.GoblinBase;
    public static readonly string GoblinBoat = PrefabNames.GoblinBoat;
    public static readonly string GoblinLoot = PrefabNames.GoblinLoot;
    public static readonly string GoblinShamanNew = PrefabNames.GoblinShamanNew;
    public static readonly string GoblinShip2 = PrefabNames.GoblinShip2;
    public static readonly string GreydwarfPurple = PrefabNames.GreydwarfPurple;
    public static readonly string GreydwarfPurpleShroom = PrefabNames.GreydwarfPurpleShroom;
    public static readonly string GreenSpider = PrefabNames.GreenSpider;
    public static readonly string IceGolem = PrefabNames.IceGolem;
    public static readonly string Molluscan = PrefabNames.Molluscan;
    public static readonly string ObsidianGolem = PrefabNames.ObsidianGolem;
    public static readonly string RainbowButterfly = PrefabNames.RainbowButterfly;
    public static readonly string SilkwormButterfly = PrefabNames.SilkwormButterfly;
    public static readonly string SkeletonWarrior = PrefabNames.SkeletonWarrior;
    public static readonly string SkeletonWarriorFire = PrefabNames.SkeletonWarriorFire;
    public static readonly string SkeletonWarriorIce = PrefabNames.SkeletonWarriorIce;
    public static readonly string TanSpider = PrefabNames.TanSpider;
    public static readonly string TreeSpider = PrefabNames.TreeSpider;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      // Mod in all zones.
      yield return RainbowButterfly;
      yield return SilkwormButterfly;

      switch (biome)
      {
        case Heightmap.Biome.BlackForest:
          yield return GhostWarrior;
          yield return SkeletonWarrior;
          yield return SkeletonWarriorIce;
          yield return SkeletonWarriorFire;
          yield return TanSpider;
          yield return ForestSpider;
          yield return GreydwarfPurple;
          yield return GreydwarfPurpleShroom;
          yield return Molluscan;
          yield return BlackSpider;
          break;

        case Heightmap.Biome.Swamp:
          yield return GreenSpider;
          break;

        case Heightmap.Biome.Mountain:
          yield return IceGolem;
          yield return SkeletonWarriorIce;
          yield return FrigidSpider;
          yield return FrostSpider;
          yield return ObsidianGolem;
          break;

        case Heightmap.Biome.Plains:
          yield return GoblinBase;
          yield return GoblinLoot;
          yield return GoblinShamanNew;
          yield return BrownSpider;
          break;

        case Heightmap.Biome.Ocean:
          yield return GoblinBoat;
          yield return GoblinShip2;
          break;

        case Heightmap.Biome.Mistlands:
          yield return TreeSpider;
          yield return BlackSpider;
          break;

        case Heightmap.Biome.AshLands:
          yield return FireGolem;
          yield return SkeletonWarriorFire;
          break;

        case Heightmap.Biome.DeepNorth:
          yield return SkeletonWarriorIce;
          yield return IceGolem;
          break;
      }
    }
  }
}
