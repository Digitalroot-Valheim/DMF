using Digitalroot.Modding.Framework.Logging;
using System;

namespace Digitalroot.Modding.Framework.Common.Hooks
{
  public class BaseHooks<THookType, TEventArgs>
    where THookType : new()
  {
    private static readonly Lazy<THookType> Lazy = new(() => new THookType());
    public static THookType Instance => Lazy.Value;

    /// <summary>
    /// ctor
    /// </summary>
    protected BaseHooks()
    {
      Logger = GetLogger();
    }

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
        Log.Error(Logger, e);
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
        Log.Error(Logger, e);
      }
    }

    #region Tracing/Loggins Helpers

    // ReSharper disable once StaticMemberInGenericType
    public readonly ITraceableLogging Logger;

    protected ITraceableLogging GetLogger()
    {
      #if DEBUG
      return new StaticSourceLogger(true);
      #else
      return new StaticSourceLogger();
      #endif
    }

    #endregion
  }
}
