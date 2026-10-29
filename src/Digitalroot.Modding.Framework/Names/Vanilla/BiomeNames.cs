using Digitalroot.Modding.Framework.Utils;
using System.Collections.Generic;

namespace Digitalroot.Modding.Framework.Names.Vanilla;

public static partial class BiomeNames
{
  public static readonly IEnumerable<string> AllNames = ReflectionUtils.AllNames(typeof(BiomeNames));
  public static readonly string None = nameof(None);
  public static readonly string Meadows = nameof(Meadows);
  public static readonly string Swamp = nameof(Swamp);
  public static readonly string Mountain = nameof(Mountain);
  public static readonly string BlackForest = nameof(BlackForest);
  public static readonly string Plains = nameof(Plains);
  public static readonly string AshLands = nameof(AshLands);
  public static readonly string DeepNorth = nameof(DeepNorth);
  public static readonly string Ocean = nameof(Ocean);
  public static readonly string Mistlands = nameof(Mistlands);
  public static readonly string All = nameof(All);
  public static readonly string Land = nameof(Land);
}
