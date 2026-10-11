using System.Collections.Generic;
using Digitalroot.Modding.Framework.Utils;

namespace Digitalroot.Modding.Framework.Names.Vanilla
{
  public static partial class CraftingStationNames
  {
    public static readonly IEnumerable<string> AllNames = ReflectionUtils.AllNames(typeof(CraftingStationNames));
    public static readonly string ArtisanTable = PrefabNames.PieceArtisanstation;
    #pragma warning disable IDE0051
    // ReSharper disable once IdentifierTypo
    public static readonly string Blackforge = PrefabNames.Blackforge;
    #pragma warning restore IDE0051
    public static readonly string Cauldron = PrefabNames.PieceCauldron;
    public static readonly string Forge = PrefabNames.Forge;
    public static string Ketill => MeadCauldron;
    // ReSharper disable once MemberCanBePrivate.Global
    public static readonly string MeadCauldron = PrefabNames.PieceMeadCauldron;
    public static readonly string MageTable = PrefabNames.PieceMagetable;
    // ReSharper disable once IdentifierTypo
    public static readonly string Preptable = PrefabNames.PiecePreptable;
    public static readonly string Stonecutter = PrefabNames.PieceStonecutter;
    public static readonly string Workbench = PrefabNames.PieceWorkbench;
  }
}
