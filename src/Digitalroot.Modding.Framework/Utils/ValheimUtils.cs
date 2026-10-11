using BepInEx.Bootstrap;
using Digitalroot.Modding.Framework.Logging;
using JetBrains.Annotations;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.Rendering;

namespace Digitalroot.Modding.Framework.Utils;

public static class ValheimUtils
{
  /// <summary>
  /// Does not work in Awake()
  /// </summary>
  [UsedImplicitly]
  public static bool IsDedicated => ZNet.instance.IsDedicated();

  /// <summary>
  /// Does not work in Awake()
  /// </summary>
  [UsedImplicitly]
  public static bool IsServer => ZNet.instance.IsServer();

  /// <summary>
  /// Works in Awake()
  /// </summary>
  [UsedImplicitly]
  public static bool IsHeadless() => SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null;

  [UsedImplicitly, Obsolete("Use isModLoaded()", true)]
  public static bool DoesPluginExist(string pluginGuid) => Chainloader.PluginInfos.Any(keyValuePair => keyValuePair.Value.Metadata.GUID == pluginGuid);

  [UsedImplicitly]
  public static bool isModLoaded(string pluginGuid) => Chainloader.PluginInfos.Any(keyValuePair => keyValuePair.Value.Metadata.GUID == pluginGuid);

  [UsedImplicitly]
  public static Vector3 GetGroundHeight(int x, int z) => GetGroundHeight(new Vector3Int(x, 500, z));

  [UsedImplicitly]
  public static Vector3 GetGroundHeight(float x, float z) => GetGroundHeight(new Vector3(x, 500, z));

  [UsedImplicitly]
  // ReSharper disable once MemberCanBePrivate.Global
  public static Vector3 GetGroundHeight(Vector3Int vector3) => new(vector3.x, ZoneSystem.instance.GetGroundHeight(vector3), vector3.z);

  [UsedImplicitly]
  // ReSharper disable once MemberCanBePrivate.Global
  public static Vector3 GetGroundHeight(Vector3 vector3) => new(vector3.x, ZoneSystem.instance.GetGroundHeight(vector3), vector3.z);

  [UsedImplicitly]
  public static GameObject GetItemPrefab(string itemName) => IsObjectDBReady() ? GetObjectDB().GetItemPrefab(itemName) : null;

  [UsedImplicitly]
  public static GameObject GetItemPrefab(int hash) => IsObjectDBReady() ? GetObjectDB().GetItemPrefab(hash) : null;

  [UsedImplicitly]
  public static Player GetLocalPlayer() => Player.m_localPlayer;

  [UsedImplicitly]
  public static Vector3 GetLocalPlayersPosition() => Player.m_localPlayer.transform.position;

  [UsedImplicitly]
  public static ObjectDB GetObjectDB() => ObjectDB.instance;

  [UsedImplicitly]
  public static string GetPluginPath(Type modPluginType) => Path.GetDirectoryName(modPluginType.Assembly.Location);

  [UsedImplicitly]
  public static GameObject GetPrefab(string itemName) => IsZNetSceneReady() ? ZNetScene.instance.GetPrefab(itemName) : null;

  [UsedImplicitly]
  public static GameObject GetPrefab(int hash) => IsZNetSceneReady() ? ZNetScene.instance.GetPrefab(hash) : null;

  [UsedImplicitly]
  public static bool IsGameInMainScene() => ZNetScene.instance != null;

  [UsedImplicitly]
  public static bool IsObjectDBReady()
  {
    // Log.Trace(Logger, $"{Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
    return (GetObjectDB() != null && GetObjectDB().m_items.Count != 0 && GetItemPrefab("Amber") != null) || EnvironmentUtils.IsRunningFromNUnit;
  }

  [UsedImplicitly]
  public static bool IsPlayerReady()
  {
    // Log.Trace(Logger, $"{Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
    return GetLocalPlayer() != null;
  }

  [UsedImplicitly]
  public static bool IsZNetSceneReady()
  {
    // Log.Trace(Logger,$"{Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
    return ZNetScene.instance != null && ZNetScene.instance?.m_prefabs is { Count: > 0 };
  }

  [UsedImplicitly]
  public static bool IsZNetReady()
  {
    // Log.Trace(Logger, $"{Namespace}.{MethodBase.GetCurrentMethod().DeclaringType?.Name}.{MethodBase.GetCurrentMethod().Name}");
    // Log.Trace($"ZNet.instance != null : {ZNet.instance != null}");
    return ZNet.instance != null;
  }

  [UsedImplicitly]
  public static string Localize(string value)
  {
    return Localization.instance.Localize(value);
  }

  [UsedImplicitly]
  public static Vector3 GetStartTemplesPosition()
  {
    if (ZoneSystem.instance.FindClosestLocation("StartTemple", Vector3.zero, out var locationInstance))
    {
      Log.Trace(StaticSourceLogger.PreMadeTraceableInstance, $"[GetStartTemplesPosition] StartTemple at {locationInstance.m_position}");
      return locationInstance.m_position;
    }

    Log.Error(StaticSourceLogger.PreMadeTraceableInstance, "[GetStartTemplesPosition] Can't find StartTemple");

    return Vector3.zero;
  }

  [UsedImplicitly]
  public static void PrintToCenterOfScreen(string msg)
  {
    Player.m_localPlayer.Message(MessageHud.MessageType.Center, msg);
  }

  [UsedImplicitly]
  public static void PrintToTopLeftOfScreen(string msg)
  {
    Player.m_localPlayer.Message(MessageHud.MessageType.TopLeft, msg);
  }

  [UsedImplicitly]
  public static GameObject Spawn([NotNull] string prefabName, Vector3 location, [CanBeNull] Transform parent = null)
  {
    Log.Trace(StaticSourceLogger.PreMadeTraceableInstance, $"{EnvironmentUtils.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}({prefabName}, {location}, {parent?.name})");
    var prefab = ObjectDB.instance.GetItemPrefab(prefabName.GetStableHashCode());
    return prefab == null ? null : Spawn(prefab, location, parent);
  }

  [UsedImplicitly]
  public static GameObject Spawn([NotNull] GameObject prefab, Vector3 location, [CanBeNull] Transform parent = null)
  {
    Log.Trace(StaticSourceLogger.PreMadeTraceableInstance, $"{EnvironmentUtils.Namespace}.{MethodBase.GetCurrentMethod()?.DeclaringType?.Name}.{MethodBase.GetCurrentMethod()?.Name}({prefab.name}, {location}, {parent?.name})");

    if (parent == null)
    {
      return UnityEngine.Object.Instantiate(prefab, location, Quaternion.identity);
    }

    return UnityEngine.Object.Instantiate(prefab, location, Quaternion.identity, parent);
  }

  // ReSharper disable once GrammarMistakeInComment
  /// <summary>
  ///     Thanks JvL
  ///     Load an assembly-embedded <see cref="AssetBundle" />. Use this if the automatic detection of the assembly fails.
  /// </summary>
  /// <param name="bundleName">Name of the bundle. Folders are point-separated e.g. folder/bundle becomes folder.bundle</param>
  /// <param name="resourceAssembly">Executing assembly</param>
  /// <returns></returns>
  public static AssetBundle LoadAssetBundleFromResources(string bundleName, Assembly resourceAssembly)
  {
    if (resourceAssembly == null)
    {
      throw new ArgumentNullException(nameof(resourceAssembly));
    }

    string resourceName = null;
    try
    {
      resourceName = resourceAssembly.GetManifestResourceNames().Single(str => str.EndsWith(bundleName));
      // ReSharper disable once EmptyGeneralCatchClause
    }
    catch (Exception)
    {
      // ignored
    }

    if (resourceName == null)
    {
      Log.Error(StaticSourceLogger.PreMadeTraceableInstance, $"AssetBundle {bundleName} not found in assembly manifest");
      return null;
    }

    using var stream = resourceAssembly.GetManifestResourceStream(resourceName);
    return AssetBundle.LoadFromStream(stream);
  }
}
