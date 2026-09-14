using UnityEngine;

namespace Digitalroot.Modding.Framework.Common.Interfaces
{
  public interface ICreateable
  {
    string Name { get; }
    string Token { get; }
    GameObject Create();
  }
}
