using UnityEngine;

namespace DMF.Common.Interfaces
{
  public interface ICreateable
  {
    string Name { get; }
    string Token { get; }
    GameObject Create();
  }
}
