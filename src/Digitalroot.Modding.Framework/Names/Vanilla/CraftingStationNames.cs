using System.Collections.Generic;
using DMF_Utils = Digitalroot.Modding.Framework.Utils.Utils;

namespace Digitalroot.Modding.Framework.Names.Vanilla
{
  public static partial class CraftingStationNames
  {
    public static readonly IEnumerable<string> AllNames = DMF_Utils.ReflectionUtils.AllNames(typeof(CraftingStationNames));
    public static readonly string ArtisanTable = PrefabNames.PieceArtisanstation;
    public static readonly string Blackforge = PrefabNames.Blackforge;
    public static readonly string Cauldron = PrefabNames.PieceCauldron;
    public static readonly string Forge = PrefabNames.Forge;
    public static string Ketill => MeadCauldron;
    public static readonly string MeadCauldron = PrefabNames.PieceMeadCauldron;
    public static readonly string MageTable = PrefabNames.PieceMagetable;
    public static readonly string Preptable = PrefabNames.PiecePreptable;
    public static readonly string Stonecutter = PrefabNames.PieceStonecutter;
    public static readonly string Workbench = PrefabNames.PieceWorkbench;
  }
}
