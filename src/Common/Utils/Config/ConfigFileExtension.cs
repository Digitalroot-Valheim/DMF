using BepInEx.Configuration;

namespace DMF.Common.Config;

/// <summary>
///     Extends <see cref="ConfigFile"/> with convenience functions.
/// </summary>
public static class ConfigFileExtension
{
  /// <summary>
  /// Create a new setting. The setting is saved to drive and loaded automatically.
  /// Each definition can be used to add only one setting, trying to add a second setting will throw an exception.
  /// </summary>
  /// <typeparam name="T">Type of the value contained in this setting.</typeparam>
  /// <param name="configFile"></param>
  /// <param name="configDefinition">Section and Key of the setting.</param>
  /// <param name="defaultValue">Value of the setting if the setting was not created yet.</param>
  /// <param name="configDescription">Description of the setting shown to the user and other metadata.</param>
  public static ConfigEntry<T> BindSyncable<T>(this ConfigFile configFile, ConfigDefinition configDefinition, T defaultValue, ConfigDescription configDescription = null)
  {
    return configFile.Bind(configDefinition, defaultValue, configDescription);
  }
}
