namespace DMF.Common.Hooks;

public static class Main
{
  public static readonly string Namespace = "Digitalroot.Valheim.Hooks";
  public static ITraceableLogging Instance => StaticSourceLogger.PreMadeTraceableInstance;
}
