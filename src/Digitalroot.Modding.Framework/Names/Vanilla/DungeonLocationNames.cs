using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;

namespace Digitalroot.Modding.Framework.Names.Vanilla
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class DungeonLocationNames
  {
    public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(DungeonLocationNames));
    public static readonly string Crypt2 = PrefabNames.Crypt2;
    public static readonly string Crypt3 = PrefabNames.Crypt3;
    public static readonly string Crypt4 = PrefabNames.Crypt4;
    public static readonly string GoblinCamp2 = PrefabNames.GoblinCamp2;
    public static readonly string SunkenCrypt4 = PrefabNames.SunkenCrypt4;
    public static readonly string TrollCave02 = PrefabNames.TrollCave02;
    public static readonly string MistlandsDvergrBossEntrance1 = PrefabNames.MistlandsDvergrBossEntrance1;
    public static readonly string MistlandsDvergrTownEntrance1 = PrefabNames.MistlandsDvergrTownEntrance1;
    public static readonly string MistlandsDvergrTownEntrance2 = PrefabNames.MistlandsDvergrTownEntrance2;
    public static readonly string MountainCave02 = PrefabNames.MountainCave02;
  }
}
