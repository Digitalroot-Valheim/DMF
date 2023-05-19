using BepInEx.Configuration;
using DMF.Common.Config.Providers;
using System;
using System.IO;

namespace DMF.Common.Config
{
  public abstract class AbstractConfigProvider
  {
    public abstract ConfigEntry<T> AddConfigEntry<T>(ConfigEntry<T> configEntry);
    public abstract ConfigEntry<T> AddConfigEntry<T>(string group, string name, T value, ConfigDescription description);
    public virtual ConfigEntry<T> AddConfigEntry<T>(string group, string name, T value, string description) => AddConfigEntry(group, name, value, new ConfigDescription(description));
    public abstract AbstractProxyCustomSyncedValue<T> AddCustomSyncedValue<T>(string identifier, T value = default);
  }

  /// <inheritdoc />
  public class SyncableConfigEntry<T>
  {
    #region ConfigEntry 

    private T _typedValue;

    public T Value => _configEntry.Value;

    /// <summary>
    /// Config file this entry is a part of.
    /// </summary>
    public ConfigFile ConfigFile => _configEntry.ConfigFile;

    /// <summary>
    /// Category and name of this setting. Used as a unique key for identification within a <see cref="Configuration.ConfigFile"/>.
    /// </summary>
    public ConfigDefinition Definition => _configEntry.Definition;

    /// <summary>
    /// Description / metadata of this setting.
    /// </summary>
    public ConfigDescription Description => _configEntry.Description;

    /// <summary>
    /// Type of the <see cref="BoxedValue"/> that this setting holds.
    /// </summary>
    public Type SettingType => _configEntry.SettingType;

    /// <summary>
    /// Default value of this setting (set only if the setting was not changed before).
    /// </summary>
    public object DefaultValue => _configEntry.DefaultValue;

    /// <summary>
    /// Get or set the value of the setting.
    /// </summary>
    public object BoxedValue => _configEntry.BoxedValue;

    #endregion

    private readonly ConfigEntry<T> _configEntry;
    
    public SyncableConfigEntry(ConfigFile configFile, ConfigDefinition definition, T defaultValue, ConfigDescription configDescription)
    {
      _configEntry = configFile.Bind(definition, defaultValue, configDescription);
      _configEntry.SettingChanged += configEntry_SettingChanged;
    }

    /// <summary>
    /// Fired when the setting is changed. Does not detect changes made outside from this object.
    /// </summary>
    public event EventHandler SettingChanged;

    private void configEntry_SettingChanged(object sender, EventArgs args)
    {
      SettingChanged?.Invoke(sender, args);
    }

    /// <summary>
    /// Get the serialized representation of the value.
    /// </summary>
    public string GetSerializedValue() => _configEntry.GetSerializedValue();

    /// <summary>
    /// Set the value by using its serialized form.
    /// </summary>
    public void SetSerializedValue(string value) => _configEntry.SetSerializedValue(value);

    /// <summary>
    /// Write a description of this setting using all available metadata.
    /// </summary>
    public void WriteDescription(StreamWriter writer) => _configEntry.WriteDescription(writer);

  }
}
