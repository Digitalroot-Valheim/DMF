namespace Digitalroot.Modding.Framework.Common.Extensions;

public static class TraderExtensions
{
  /// <summary>
  /// Is the current trader Haldor
  /// </summary>
  /// <param name="trader"></param>
  /// <returns>True if the current trader Haldor</returns>
  public static bool IsHaldor(this Trader trader)
  {
    return trader != null && trader.m_name == "$npc_haldor";
  }
}
