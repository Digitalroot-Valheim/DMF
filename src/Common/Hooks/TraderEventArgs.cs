using System;

namespace DMF.Common.Hooks;

public class TraderEventArgs : EventArgs
{
  public Trader Trader { get; internal set; }
}
