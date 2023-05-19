using JetBrains.Annotations;
using System.Collections.Generic;

namespace DMF.Common.Names.MonsterLabZMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string BlackSpider = nameof(BlackSpider);
    public static readonly string BrownSpider = nameof(BrownSpider);
    public static readonly string FireGolem = nameof(FireGolem);
    public static readonly string ForestSpider = nameof(ForestSpider);
    public static readonly string FrigidSpider = nameof(FrigidSpider);
    public static readonly string FrostSpider = nameof(FrostSpider);
    public static readonly string GhostWarrior = nameof(GhostWarrior);
    public static readonly string GoblinBase = nameof(GoblinBase);
    public static readonly string GoblinBoat = nameof(GoblinBoat);
    public static readonly string GoblinLoot = nameof(GoblinLoot);
    public static readonly string GoblinShamanNew = nameof(GoblinShamanNew);
    public static readonly string GoblinShip2 = nameof(GoblinShip2);
    public const string GreydwarfPurple = "Greydwarf_Purple";
    public const string GreydwarfPurpleShroom = "Greydwarf_Purple_Shroom";
    public static readonly string GreenSpider = nameof(GreenSpider);
    public static readonly string IceGolem = nameof(IceGolem);
    public static readonly string Kraken = nameof(Kraken);
    // ReSharper disable once InconsistentNaming
    public static readonly string KrakenLD = nameof(KrakenLD);
    public static readonly string Molluscan = nameof(Molluscan);
    public static readonly string ObsidianGolem = nameof(ObsidianGolem);
    public const string RainbowButterfly = "Rainbow_Butterfly";
    public const string SilkwormButterfly = "Silkworm_Butterfly";
    public static readonly string SkeletonWarrior = nameof(SkeletonWarrior);
    public static readonly string SkeletonWarriorFire = nameof(SkeletonWarriorFire);
    public static readonly string SkeletonWarriorIce = nameof(SkeletonWarriorIce);
    public const string SpiderBoss = "Spider_Boss";
    public static readonly string TanSpider = nameof(TanSpider);
    public static readonly string TreeSpider = nameof(TreeSpider);
  }
}
