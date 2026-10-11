using JetBrains.Annotations;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Digitalroot.Modding.Framework.Utils;

public static class EnvironmentUtils
{
  [UsedImplicitly]
  public static DirectoryInfo AssemblyDirectory
  {
    get
    {
      var codeBase = Assembly.GetExecutingAssembly().CodeBase;
      UriBuilder uri = new(codeBase);
      var fileInfo = new FileInfo(Uri.UnescapeDataString(uri.Path));
      return fileInfo.Directory;
    }
  }

  // ReSharper disable once MemberCanBePrivate.Global
  // ReSharper disable once StringLiteralTypo
  public static bool IsRunningFromNUnit => AppDomain.CurrentDomain.GetAssemblies().Any(a => a.FullName.ToLowerInvariant().StartsWith("nunit.framework"));

  /// <summary>
  /// Does not work in Awake()
  /// </summary>
  [UsedImplicitly, Obsolete("Use ValheimUtils.IsDedicated", true)]
  public static bool IsDedicated => ValheimUtils.IsDedicated;

  /// <summary>
  /// Does not work in Awake()
  /// </summary>
  [UsedImplicitly, Obsolete("Use ValheimUtils.IsServer", true)]
  public static bool IsServer => ValheimUtils.IsServer;

  /// <summary>
  /// Works in Awake()
  /// </summary>
  [UsedImplicitly, Obsolete("Use ValheimUtils.IsHeadless", true)]
  public static bool IsHeadless() => ValheimUtils.IsHeadless();

  // ReSharper disable once MemberCanBePrivate.Global
  [UsedImplicitly]
  public static string Namespace => $"{nameof(Digitalroot)}.{nameof(Modding)}.{nameof(Framework)}";
}
