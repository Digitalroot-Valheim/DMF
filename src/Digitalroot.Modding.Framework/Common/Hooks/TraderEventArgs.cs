using System;

namespace Digitalroot.Modding.Framework.Common.Hooks;

public class TraderEventArgs : EventArgs
{
  public Trader Trader { get; internal set; }
}
