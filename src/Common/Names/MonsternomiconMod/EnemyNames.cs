using JetBrains.Annotations;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global

namespace DMF.Common.Names.MonsternomiconMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class EnemyNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(EnemyNames));
    public static readonly string AngrySpirit = PrefabNames.AngrySpirit;
    public static readonly string AngryFrozenCorpse = PrefabNames.AngryFrozenCorpse;
    public static readonly string AshHatchling = PrefabNames.AshHatchling;
    public static readonly string AshMosquito = PrefabNames.AshMosquito;
    public static readonly string AshNeck = PrefabNames.AshNeck;
    public static readonly string BlazingBones = PrefabNames.BlazingBones;
    public static readonly string CalmSpirit = PrefabNames.CalmSpirit;
    public static readonly string DarkMosquito = PrefabNames.DarkMosquito;
    public static readonly string DarkProtector = PrefabNames.DarkProtector;
    public static readonly string DarkSpider = PrefabNames.DarkSpider;
    public static readonly string Dvergr = PrefabNames.Dvergr;
    public static readonly string ElderSurtling = PrefabNames.ElderSurtling;
    public static readonly string FrozenCorpse = PrefabNames.FrozenCorpse;
    public static readonly string PoisonDarkSpider = PrefabNames.PoisonDarkSpider;
    public static readonly string PolarFenring = PrefabNames.PolarFenring;
    public static readonly string PolarLox = PrefabNames.PolarLox;
    public static readonly string DrownedSoul = PrefabNames.DrownedSoul;
    public static readonly string SilverGolem = PrefabNames.SilverGolem;
    public static readonly string SmallAshNeck = PrefabNames.SmallAshNeck;
    public static readonly string SmallDarkSpider = PrefabNames.SmallDarkSpider;
    public static readonly string PolarSerpentSmall = PrefabNames.PolarSerpentSmall;
    public static readonly string PolarLoxSmall = PrefabNames.PolarLoxSmall;
    public static readonly string StormHatchling = PrefabNames.StormHatchling;
    public static readonly string SwollenBody = PrefabNames.SwollenBody;
    public static readonly string StormWolf = PrefabNames.StormWolf;
    public static readonly string BurnedBones = PrefabNames.BurnedBones;
    public static readonly string Svartalfr = PrefabNames.Svartalfr;
    public static readonly string SvartalfrArcher = PrefabNames.SvartalfrArcher;
    public static readonly string SvartalfrMage = PrefabNames.SvartalfrMage;
    public static readonly string SvartalfrHeavy = PrefabNames.SvartalfrHeavy;
    public static readonly string SvartalfrBrigade = PrefabNames.SvartalfrBrigade;

    [UsedImplicitly]
    public static IEnumerable<string> AllNamesByBiome(Heightmap.Biome biome)
    {
      switch (biome)
      {
        case Heightmap.Biome.Mountain:
          yield return StormWolf;
          break;

        case Heightmap.Biome.Ocean:
          yield return DrownedSoul;
          yield return StormHatchling;
          yield return PolarSerpentSmall;
          break;

        case Heightmap.Biome.Mistlands:
          yield return DarkMosquito;
          yield return DarkProtector;
          yield return DarkSpider;
          yield return PoisonDarkSpider;
          yield return Svartalfr;
          yield return SmallDarkSpider;
          yield return SvartalfrArcher;
          yield return SvartalfrBrigade;
          yield return SvartalfrHeavy;
          yield return SvartalfrMage;
          break;

        case Heightmap.Biome.AshLands:
          yield return AshHatchling;
          yield return AshMosquito;
          yield return AshNeck;
          yield return BlazingBones;
          yield return BurnedBones;
          yield return ElderSurtling;
          yield return SmallAshNeck;
          yield return SwollenBody;
          break;

        case Heightmap.Biome.DeepNorth:
          yield return AngryFrozenCorpse;
          yield return AngrySpirit;
          yield return CalmSpirit;
          yield return Dvergr;
          yield return FrozenCorpse;
          yield return PolarFenring;
          yield return PolarLox;
          yield return SilverGolem;
          yield return PolarLoxSmall;
          break;
      }
    }
  }
}
