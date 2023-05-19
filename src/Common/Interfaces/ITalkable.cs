using UnityEngine;

namespace DMF.Common.Interfaces
{
  public interface ITalkable
  {
    Transform Head { get; set; }
    GameObject Talker { get; set; }

    void Say(string topic, string msg);
  }
}
