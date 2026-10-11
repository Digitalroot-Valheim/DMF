using JetBrains.Annotations;
using System.Collections.Generic;
using Digitalroot.Modding.Framework.Utils;

namespace Digitalroot.Modding.Framework.Names.BearsMod
{
  // ReSharper disable once PartialTypeWithSinglePart
  public static partial class PrefabNames
  {
    [UsedImplicitly] public static readonly IEnumerable<string> AllNames = ReflectionUtils.AllNames(typeof(PrefabNames));
    public static readonly string Bear = nameof(Bear);
    public const string BearCub = "Bear_cub";
  }
}
