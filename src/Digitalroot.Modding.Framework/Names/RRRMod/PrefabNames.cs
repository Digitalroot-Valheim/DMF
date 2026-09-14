using JetBrains.Annotations;
using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;

namespace Digitalroot.Modding.Framework.Names.RRRMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    private const string PrefixBase = "RRR_";

    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(PrefabNames));
    public static readonly string TrollTosser = $"{PrefixBase}{nameof(TrollTosser)}";
    // ReSharper disable once InconsistentNaming
    public static readonly string GDThornweaver = $"{PrefixBase}{nameof(GDThornweaver)}";
    public static readonly string GhostVengeful = $"{PrefixBase}{nameof(GhostVengeful)}";
    public static readonly string Grig = $"{PrefixBase}{nameof(Grig)}";
  }
}
