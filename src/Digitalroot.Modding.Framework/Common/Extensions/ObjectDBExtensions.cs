using UnityEngine;

namespace Digitalroot.Modding.Framework.Common.Extensions
{
  public static class ObjectDBExtensions
  {
    public static bool Contains(this ObjectDB objectDB, GameObject gameObject)
    {
      return objectDB.GetItemPrefab(gameObject.GetHashCode()) != null;
    }
  }
}
