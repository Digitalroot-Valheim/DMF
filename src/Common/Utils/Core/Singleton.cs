using JetBrains.Annotations;
using System;

namespace DMF.Common.Core
{
  public abstract class Singleton<SingletonSubClass> where SingletonSubClass : Singleton<SingletonSubClass>, new()
  {
    public static SingletonSubClass Instance => Nested._instance;

    [UsedImplicitly]
    private class Nested
    {
      static Nested()
      {
      }

      // ReSharper disable once InconsistentNaming
      internal static readonly SingletonSubClass _instance = InstantiateInstance();

      private static SingletonSubClass InstantiateInstance()
      {
        SingletonSubClass instance;
        try
        {
          instance = new SingletonSubClass();
        }
        catch (Exception ex)
        {
          Log.Error(StaticSourceLogger.PreMadeTraceableInstance, ex);
          Log.Error(StaticSourceLogger.PreMadeTraceableInstance, $"Failed while initializing singleton of type: {typeof(SingletonSubClass).FullName}: {ex.Message}");
          throw;
        }
        return instance;
      }
    }
  }
}
