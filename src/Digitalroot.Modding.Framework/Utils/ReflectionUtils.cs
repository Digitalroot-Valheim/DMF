using Digitalroot.Modding.Framework.Logging;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Digitalroot.Modding.Framework.Utils;

public static class ReflectionUtils
{
  [UsedImplicitly]
  public static List<T> AllOf<T>() => Enum.GetValues(typeof(T)).OfType<T>().ToList();

  [UsedImplicitly]
  public static IEnumerable<string> AllNames(Type type)
  {
    foreach (var fieldInfo in type.GetFields().Where(f1 => f1.FieldType == typeof(string)))
    {
      yield return fieldInfo.GetValue(null).ToString();
    }
  }

  [UsedImplicitly]
  public static T GetPrivateField<T>(object instance, string name)
  {
    var var = instance.GetType().GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);
    if (var != null) return (T)var.GetValue(instance);
    Log.Error(StaticSourceLogger.PreMadeTraceableInstance, $"Variable {name} does not exist on type: {instance.GetType()}");
    return default;
  }

  [UsedImplicitly]
  public static object InvokePrivate(object instance, string name, object[] args = null)
  {
    var method = instance.GetType().GetMethod(name, BindingFlags.NonPublic | BindingFlags.Instance);

    if (method == null)
    {
      var types = args == null ? Type.EmptyTypes : args.Select(arg => arg.GetType()).ToArray();
      method = instance.GetType().GetMethod(name, types);
    }

    if (method == null)
    {
      Log.Error(StaticSourceLogger.PreMadeTraceableInstance, $"Method {name} does not exist on type: {instance.GetType()}");
      return null;
    }

    return method.Invoke(instance, args);
  }

  [UsedImplicitly]
  public static void SetPrivateField(object instance, string name, object value)
  {
    var var = instance.GetType().GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);

    if (var == null)
    {
      Log.Error(StaticSourceLogger.PreMadeTraceableInstance, $"Variable {name} does not exist on type: {instance.GetType()}");
      return;
    }

    var.SetValue(instance, value);
  }
}
