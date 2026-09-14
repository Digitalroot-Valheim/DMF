using JetBrains.Annotations;
using System.Diagnostics.CodeAnalysis;

namespace Digitalroot.Modding.Framework.Common.Json
{
  [UsedImplicitly]
  [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
  public static class JsonSerializationProvider
  {
    public static T Deserialize<T>(string json)
    {
      return SimpleJson.SimpleJson.DeserializeObject<T>(json, new DigitalrootJsonSerializerStrategy());
    }

    public static string Serialize(object obj)
    {
      return SimpleJson.SimpleJson.SerializeObject(obj, new DigitalrootJsonSerializerStrategy());
    }
  }
}
