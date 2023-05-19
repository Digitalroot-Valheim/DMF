namespace DMF.Common.Config.Providers.BepInEx;

internal class BepInExInMemoryBasedConfigProvider : AbstractBepInExConfigProvider
{
  public BepInExInMemoryBasedConfigProvider(ConfigProviderSettings configProviderSettings)
    : base(configProviderSettings, false) {
      
  }
}
