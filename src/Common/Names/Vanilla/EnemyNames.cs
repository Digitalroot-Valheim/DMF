using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.Vanilla
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));
    public static readonly string Abomination = PrefabNames.Abomination;
    public static readonly string Blob = PrefabNames.Blob;
    public static readonly string BlobElite = PrefabNames.BlobElite;
    public static readonly string BlobTar = PrefabNames.BlobTar;
    public static readonly string Boar = PrefabNames.Boar;
    public static readonly string BoarPiggy = PrefabNames.BoarPiggy;
    public static readonly string Crow = PrefabNames.Crow;
    public static readonly string Deathsquito = PrefabNames.Deathsquito;
    public static readonly string Deer = PrefabNames.Deer;
    public static readonly string Drake = PrefabNames.Hatchling;
    public static readonly string Draugr = PrefabNames.Draugr;
    public static readonly string DraugrElite = PrefabNames.DraugrElite;
    public static readonly string DraugrRanged = PrefabNames.DraugrRanged;
    public static readonly string Dverger = PrefabNames.Dverger;
    public static readonly string Fenring = PrefabNames.Fenring;
    public static readonly string Ghost = PrefabNames.Ghost;
    public static readonly string Gjall = PrefabNames.Gjall;
    public static readonly string Goblin = PrefabNames.Goblin;
    public static readonly string GoblinArcher = PrefabNames.GoblinArcher;
    public static readonly string GoblinBrute = PrefabNames.GoblinBrute;
    public static readonly string GoblinShaman = PrefabNames.GoblinShaman;
    public static readonly string Greydwarf = PrefabNames.Greydwarf;
    public static readonly string GreydwarfElite = PrefabNames.GreydwarfElite;
    public static readonly string GreydwarfShaman = PrefabNames.GreydwarfShaman;
    public static readonly string Greyling = PrefabNames.Greyling;
    public static readonly string Hare = PrefabNames.Hare;
    public static readonly string Hen = PrefabNames.Hen;
    public static readonly string Hive = PrefabNames.Hive;
    public static readonly string Leech = PrefabNames.Leech;
    public static readonly string Lox = PrefabNames.Lox;
    public static readonly string LoxCalf = PrefabNames.LoxCalf;
    public static readonly string Mistile = PrefabNames.Mistile;
    public static readonly string Neck = PrefabNames.Neck;
    public static readonly string Seagal = PrefabNames.Seagal;
    public static readonly string Seeker = PrefabNames.Seeker;
    public static readonly string SeekerBrute = PrefabNames.SeekerBrute;
    public static readonly string Serpent = PrefabNames.Serpent;
    public static readonly string Skeleton = PrefabNames.Skeleton;
    public static readonly string SkeletonNoArcher = PrefabNames.SkeletonNoArcher;
    public static readonly string SkeletonPoison = PrefabNames.SkeletonPoison;
    public static readonly string StoneGolem = PrefabNames.StoneGolem;
    public static readonly string Surtling = PrefabNames.Surtling;
    public static readonly string TheHive = PrefabNames.TheHive;
    public static readonly string Tick = PrefabNames.Tick;
    public static readonly string Troll = PrefabNames.Troll;
    public static readonly string Wolf = PrefabNames.Wolf;
    public static readonly string WolfCub = PrefabNames.WolfCub;
    public static readonly string Wraith = PrefabNames.Wraith;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Meadows:
          yield return Boar;
          yield return BoarPiggy;
          yield return Deer;
          yield return Draugr;
          yield return Ghost;
          yield return Greyling;
          yield return Greydwarf;
          yield return GreydwarfElite;
          yield return GreydwarfShaman;
          yield return Neck;
          yield return Seagal;
          yield return Skeleton;
          break;

        case Heightmap.Biome.BlackForest:
          yield return Crow;
          yield return Deer;
          yield return Ghost;
          yield return Greydwarf;
          yield return GreydwarfElite;
          yield return GreydwarfShaman;
          yield return Skeleton;
          yield return SkeletonPoison;
          yield return Troll;
          break;

        case Heightmap.Biome.Swamp:
          yield return Abomination;
          yield return Blob;
          yield return BlobElite;
          yield return Draugr;
          yield return DraugrElite;
          yield return DraugrRanged;
          yield return Leech;
          yield return Surtling;
          yield return Wraith;
          break;

        case Heightmap.Biome.Mountain:
          yield return Drake;
          yield return Fenring;
          yield return StoneGolem;
          yield return Wolf;
          yield return WolfCub;
          break;

        case Heightmap.Biome.Plains:
          yield return BlobTar;
          yield return Deathsquito;
          yield return Goblin;
          yield return GoblinArcher;
          yield return GoblinBrute;
          yield return GoblinShaman;
          yield return Lox;
          yield return LoxCalf;
          break;

        case Heightmap.Biome.Ocean:
          yield return Serpent;
          break;

        case Heightmap.Biome.Mistlands:
          yield return Dverger;
          yield return Gjall;
          yield return Hare;
          yield return Seeker;
          yield return SeekerBrute;
          yield return Tick;
          break;
      }
    }
  }
}
