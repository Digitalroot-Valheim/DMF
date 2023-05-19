using BepInEx.Configuration;

namespace DMF.Common.Config;

/// <summary>
/// 
/// </summary>
public struct ConfigurationContext
{
  /// <summary>
  /// 
  /// </summary>
  public string ConfigGuid { get; private set; }

  /// <summary>
  /// 
  /// </summary>
  public ConfigFile ConfigFile { get; private set; }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="configGuid"></param>
  /// <param name="configFile"></param>
  public ConfigurationContext(string configGuid, ConfigFile configFile)
  {
    ConfigGuid = configGuid;
    ConfigFile = configFile;
  }

  /// <summary>
  /// 
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="configurationName"></param>
  /// <returns></returns>
  public T GetConfigurationValue<T>(string configurationName) => GlobalConfigurationManager.Instance.GetConfigurationValue<T>(ConfigGuid, configurationName);
}
