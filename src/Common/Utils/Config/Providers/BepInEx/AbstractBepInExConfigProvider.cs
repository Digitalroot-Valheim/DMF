using BepInEx;
using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace DMF.Common.Config.Providers.BepInEx
{
  internal abstract class AbstractBepInExConfigProvider : AbstractConfigProvider
  {
    private ConfigFile ConfigInstance { get; set; }
    private Dictionary<string, object> CustomValues { get; set; }

    protected AbstractBepInExConfigProvider(ConfigProviderSettings configProviderSettings, bool saveOnInit = true)
    {
      ConfigInstance = new ConfigFile(Path.Combine(Paths.ConfigPath, $"{configProviderSettings.ModGuid}.cfg")
                                      , saveOnInit
                                      , configProviderSettings.Plugin.Info.Metadata);
    }


    #region Overrides of AbstractConfigProvider

    /// <inheritdoc />
    public override ConfigEntry<T> AddConfigEntry<T>(ConfigEntry<T> configEntry)
    {
      return ConfigInstance.Bind(configEntry.Definition, (T)configEntry.DefaultValue, configEntry.Description);
    }

    /// <inheritdoc />
    public override ConfigEntry<T> AddConfigEntry<T>(string section, string key, T defaultValue, ConfigDescription description)
    {
      return ConfigInstance.Bind(section, key, defaultValue, description);
    }

    /// <inheritdoc />
    public override AbstractProxyCustomSyncedValue<T> AddCustomSyncedValue<T>(string identifier, T value = default)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
