using DMF.Common.Config.Providers;
using DMF.Common.Config.Providers.BepInEx;
using DMF.Common.Config.Providers.JvL;
using System;

namespace DMF.Common.Config
{
  public static class ConfigProviderFactory
  {
    public static AbstractConfigProvider GetConfigProvider(ConfigProviderType configProviderType, ConfigProviderSettings configProviderSettings)
    {
      return configProviderType switch
      {
        ConfigProviderType.JvL => new JvLAbstractConfigProvider()
        , ConfigProviderType.ServerSync => new ServerSyncConfigProvider(configProviderSettings)
        , ConfigProviderType.BepInExFileBasedConfig => new BepInExFileBasedConfigProvider(configProviderSettings)
        , ConfigProviderType.BepInExInMemoryBasedConfig => new BepInExInMemoryBasedConfigProvider(configProviderSettings)
        , _ => throw new ArgumentOutOfRangeException(nameof(configProviderType), configProviderType, null)
      };
    }
  }
}
