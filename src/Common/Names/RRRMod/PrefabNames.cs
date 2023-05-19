using JetBrains.Annotations;
using System.Collections.Generic;

namespace DMF.Common.Names.RRRMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    private const string PrefixBase = "RRR_";

    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = Utils.AllNames(typeof(PrefabNames));
    public static readonly string TrollTosser = $"{PrefixBase}{nameof(TrollTosser)}";
    // ReSharper disable once InconsistentNaming
    public static readonly string GDThornweaver = $"{PrefixBase}{nameof(GDThornweaver)}";
    public static readonly string GhostVengeful = $"{PrefixBase}{nameof(GhostVengeful)}";
    public static readonly string Grig = $"{PrefixBase}{nameof(Grig)}";
  }
}
