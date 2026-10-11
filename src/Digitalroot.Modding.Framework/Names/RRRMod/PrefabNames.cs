using JetBrains.Annotations;
using System.Collections.Generic;
using Digitalroot.Modding.Framework.Utils;

namespace Digitalroot.Modding.Framework.Names.RRRMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    private const string PrefixBase = "RRR_";

    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = ReflectionUtils.AllNames(typeof(PrefabNames));
    public static readonly string TrollTosser = $"{PrefixBase}{nameof(TrollTosser)}";
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once IdentifierTypo
    public static readonly string GDThornweaver = $"{PrefixBase}{nameof(GDThornweaver)}";
    public static readonly string GhostVengeful = $"{PrefixBase}{nameof(GhostVengeful)}";
    // ReSharper disable once IdentifierTypo
    public static readonly string Grig = $"{PrefixBase}{nameof(Grig)}";
  }
}
