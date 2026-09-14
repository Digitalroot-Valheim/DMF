using Digitalroot.Modding.Framework.Logging;
using HarmonyLib;
using System;
using System.Reflection;
using static Digitalroot.Modding.Framework.Utils.Utils;

namespace Digitalroot.Modding.Framework.Common.Hooks
{
  public sealed class TraderHooks : BaseHooks<TraderHooks, TraderEventArgs>
  {
    public TraderHooks() { }
    internal void OnBeforeStart(ref Trader trader) { }

    internal void OnAfterStart(ref Trader trader)
    {
      base.OnAfterStart(new TraderEventArgs { Trader = trader });
    }
  }

  [HarmonyPatch(typeof(Trader))]
  // ReSharper disable once InconsistentNaming
  public class Trader_Patches
  {
    [HarmonyPrefix, HarmonyPatch(nameof(Trader.Start))]
    // ReSharper disable once InconsistentNaming
    private static void TraderStartPrefix(ref Trader __instance)
    {
      try
      {
        Log.Trace(TraderHooks.Instance.Logger, $"{EnvironmentUtils.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        TraderHooks.Instance.OnBeforeStart(ref __instance);
      }
      catch (Exception e)
      {
        Log.Error(TraderHooks.Instance.Logger, e);
      }
    }

    [HarmonyPostfix, HarmonyPatch(nameof(Trader.Start))]
    // ReSharper disable once InconsistentNaming
    private static void TraderStartPostfix(ref Trader __instance)
    {
      try
      {
        Log.Trace(TraderHooks.Instance.Logger, $"{EnvironmentUtils.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        TraderHooks.Instance.OnAfterStart(ref __instance);
        // TraderHooks.StartPostfix
      }
      catch (Exception e)
      {
        Log.Error(TraderHooks.Instance.Logger, e);
      }
    }

    [HarmonyPrefix, HarmonyPatch(nameof(Trader.DiscoverItems))]
    // ReSharper disable 2 InconsistentNaming
    private static void TraderDiscoverItemsPrefix(ref Trader __instance, ref Player __player)
    {
      try
      {
        Log.Trace(TraderHooks.Instance.Logger, $"{EnvironmentUtils.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}");
        TraderHooks.Instance.OnBeforeStart(ref __instance);
      }
      catch (Exception e)
      {
        Log.Error(TraderHooks.Instance.Logger, e);
      }
    }
  }
}
