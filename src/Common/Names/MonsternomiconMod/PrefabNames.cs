using JetBrains.Annotations;
using System.Collections.Generic;

namespace DMF.Common.Names.MonsternomiconMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    private const string PrefixM = "RRRM_";
    private const string PrefixNpc = "RRRN_";
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));

    // Ashlands
    public static readonly string AshHatchling = $"{PrefixM}{nameof(AshHatchling)}";
    public static readonly string AshMosquito = $"{PrefixM}{nameof(AshMosquito)}";
    public static readonly string AshNeck = $"{PrefixM}{nameof(AshNeck)}";
    public static readonly string BlazingBones = $"{PrefixM}{nameof(BlazingBones)}";
    public static readonly string BlazingDamnedOne = $"{PrefixM}{nameof(BlazingDamnedOne)}"; // Fire
    public static readonly string BurnedBones = $"{PrefixM}{nameof(BurnedBones)}";
    public static readonly string DamnedOne = $"{PrefixM}{nameof(DamnedOne)}"; // Poisen
    
    public static readonly string ElderSurtling = $"{PrefixM}{nameof(ElderSurtling)}";
    public static readonly string SmallAshNeck = $"{PrefixM}{nameof(SmallAshNeck)}";
    public static readonly string SwollenBody = $"{PrefixM}{nameof(SwollenBody)}";

    // Deep North
    public static readonly string AngrySpirit = $"{PrefixM}{nameof(AngrySpirit)}";
    public static readonly string AngryFrozenCorpse = $"{PrefixM}{nameof(AngryFrozenCorpse)}";
    public static readonly string CalmSpirit = $"{PrefixM}{nameof(CalmSpirit)}";
    public static readonly string DevourerFenring = $"{PrefixM}{nameof(DevourerFenring)}"; // Ice
    public static readonly string Dvergr = $"{PrefixNpc}{nameof(Dvergr)}";
    public static readonly string DvergrEvent = $"{PrefixNpc}{nameof(DvergrEvent)}";
    public static readonly string ForgottenOne = $"{PrefixM}{nameof(ForgottenOne)}"; // Ice
    public static readonly string FrozenCorpse = $"{PrefixM}{nameof(FrozenCorpse)}";
    public static readonly string Jotunn = $"{PrefixM}{nameof(Jotunn)}";
    public static readonly string PolarFenring = $"{PrefixM}{nameof(PolarFenring)}";
    public static readonly string PolarLox = $"{PrefixM}{nameof(PolarLox)}";
    public static readonly string SilverGolem = $"{PrefixM}{nameof(SilverGolem)}";
    public static readonly string PolarLoxSmall = $"{PrefixM}{nameof(PolarLoxSmall)}";
    public static readonly string PolarSerpentSmall = $"{PrefixM}{nameof(PolarSerpentSmall)}";

    // Mistlands
    public static readonly string DarkMosquito = $"{PrefixM}{nameof(DarkMosquito)}";
    public static readonly string DarkProtector = $"{PrefixM}{nameof(DarkProtector)}";
    public static readonly string DarkSpider = $"{PrefixM}{nameof(DarkSpider)}";
    public static readonly string MotherDarkSpider = $"{PrefixM}{nameof(MotherDarkSpider)}";
    public static readonly string PoisonDarkSpider = $"{PrefixM}{nameof(PoisonDarkSpider)}";
    public static readonly string SmallDarkSpider = $"{PrefixM}{nameof(SmallDarkSpider)}";
    public static readonly string Svartalfr = $"{PrefixNpc}{nameof(Svartalfr)}";
    public static readonly string SvartalfrArcher = $"{PrefixNpc}{nameof(SvartalfrArcher)}";
    public static readonly string SvartalfrBrigade = $"{PrefixNpc}{nameof(SvartalfrBrigade)}";
    public static readonly string SvartalfrMage = $"{PrefixNpc}{nameof(SvartalfrMage)}";
    public static readonly string SvartalfrHeavy = $"{PrefixNpc}{nameof(SvartalfrHeavy)}";
    public static readonly string SvartalfrQueen = $"{PrefixNpc}{nameof(SvartalfrQueen)}";

    // Ocean
    public static readonly string DrownedSoul = $"{PrefixM}{nameof(DrownedSoul)}";
    public static readonly string StormHatchling = $"{PrefixM}{nameof(StormHatchling)}";
    
    // Other
    public static readonly string StormWolf = $"{PrefixM}{nameof(StormWolf)}";
    public static readonly string StormFenring = $"{PrefixM}{nameof(StormFenring)}";
  }
}
