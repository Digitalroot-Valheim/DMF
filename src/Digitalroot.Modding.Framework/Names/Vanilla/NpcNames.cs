using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;
namespace Digitalroot.Modding.Framework.Names.Vanilla;

public static partial class NpcNames
{
  public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(NpcNames));
  public static readonly string Haldor = PrefabNames.Haldor;
  public static readonly string Hildir = PrefabNames.Hildir;
  public static readonly string BogWitch = PrefabNames.BogWitch;
  public static readonly string Odin = PrefabNames.Odin;
  public static readonly string BogWitchKvastur = PrefabNames.BogWitchKvastur;
}
