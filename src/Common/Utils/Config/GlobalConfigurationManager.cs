using BepInEx.Configuration;
using DMF.Common.Core;
using System.Collections.Generic;

namespace DMF.Common.Config
{
  public sealed class GlobalConfigurationManager : Singleton<GlobalConfigurationManager>
  {
    /// <summary>
    /// Collection of Local Config Files
    /// </summary>
    private static readonly Dictionary<string, ConfigFile> _localClientConfigFiles  = new();
    private static readonly HashSet<ConfigFile> _remoteServerConfigFiles = new();

    public void Init()
    {

    }

    /// <summary>
    /// Adds a new config file to the GlobalConfigurationManager to manage
    /// </summary>
    /// <param name="configGuid"></param>
    /// <param name="configFile"></param>
    public ConfigurationContext AddConfigFile(string configGuid, ConfigFile configFile)
    {
      if (!_localClientConfigFiles.ContainsKey(configGuid))
      {
        _localClientConfigFiles.Add(configGuid, configFile);
      }
      
      return new ConfigurationContext(configGuid, configFile);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="configGuid"></param>
    /// <param name="configurationName"></param>
    /// <returns></returns>
    public T GetConfigurationValue<T>(string configGuid, string configurationName)
    {
      if (_localClientConfigFiles.TryGetValue(configGuid, out var configFile))
      {
        if (configFile.TryGetEntry("", "", out ConfigEntry<T> entry))
        {
          // entry.Definition.
          return entry.Value;
        }
      }
      return default;
    }

    public T GetConfigurationValue<T>(ConfigurationContext configurationContext, string configurationName) => GetConfigurationValue<T>(configurationContext.ConfigGuid, configurationName);
    
  }
}
