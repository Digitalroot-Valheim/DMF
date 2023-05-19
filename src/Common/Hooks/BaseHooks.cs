using System;

namespace DMF.Common.Hooks;

public class BaseHooks<THookType, TEventArgs>
  where THookType : new()
{
  private static readonly Lazy<THookType> Lazy = new(() => new THookType());
  public static THookType Instance => Lazy.Value;

  /// <summary>
  /// ctor
  /// </summary>
  protected BaseHooks() { }

  public delegate void StartPrefix(TEventArgs eventArgs);

  public event StartPrefix BeforeStart;

  protected virtual void OnBeforeStart(TEventArgs eventArgs)
  {
    try
    {
      BeforeStart?.Invoke(eventArgs);
    }
    catch (Exception e)
    {
      Log.Error(Main.Instance, e);
    }
  }

  public delegate void StartPostfix(TEventArgs eventArgs);

  public event StartPostfix AfterStart;

  protected virtual void OnAfterStart(TEventArgs eventArgs)
  {
    try
    {
      AfterStart?.Invoke(eventArgs);
    }
    catch (Exception e)
    {
      Log.Error(Main.Instance, e);
    }
  }
}
